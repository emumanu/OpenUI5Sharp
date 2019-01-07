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
			/// An abstract container for sections and subsections in the {@link sap.uxap.ObjectPageLayout}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageSectionBase")]
			public abstract partial class ObjectPageSectionBase : sap.ui.core.Control
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
					/// Section Title
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> title;

					/// <summary>
					/// Determines the ARIA level of the <code>ObjectPageSectionBase</code> title. The ARIA level is used by assisting technologies, such as screen readers, to create a hierarchical site map for faster navigation.
					/// 
					/// <b>Note:</b> Defining a <code>titleLevel</code> will add <code>aria-level</code> attribute from 1 to 6, instead of changing the <code>ObjectPageSectionBase</code> title HTML tag from H1 to H6. <br>For example: if <code>titleLevel</code> is <code>TitleLevel.H1</code>, it will result as aria-level of 1 added to the <code>ObjectPageSectionBase</code> title.
					/// </summary>
					public Union<sap.ui.core.TitleLevel, string, sap.ui.@base.ManagedObject.BindPropertyInfo> titleLevel;

					/// <summary>
					/// Invisible ObjectPageSectionBase are not rendered
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// Determines whether the section will be hidden on low resolutions.
					/// </summary>
					public Union<sap.uxap.Importance, string, sap.ui.@base.ManagedObject.BindPropertyInfo> importance;

					/// <summary>
					/// The custom button that will provide a link to the section in the ObjectPageLayout anchor bar. This button will be used as a custom template to be into the ObjectPageLayout anchorBar area, therefore property changes happening on this button template after the first rendering won't affect the actual button copy used in the anchorBar.
					/// 
					/// If you want to change some of the button properties, you would need to bind them to a model.
					/// </summary>
					public Union<sap.m.Button, string, sap.ui.@base.ManagedObject.BindAggregationInfo> customAnchorBarButton;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageSectionBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageSectionBase(string sId, sap.uxap.ObjectPageSectionBase.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageSectionBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageSectionBase(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageSectionBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectPageSectionBase();

				/// <summary>
				/// Constructor for a new <code>ObjectPageSectionBase</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageSectionBase(sap.uxap.ObjectPageSectionBase.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property title

				/// <summary>
				/// Gets current value of property {@link #getTitle title}.
				/// 
				/// Section Title
				/// </summary>
				/// <returns>Value of property <code>title</code></returns>
				public extern virtual string getTitle();

				/// <summary>
				/// Sets a new value for property {@link #getTitle title}.
				/// 
				/// Section Title
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTitle">New value for property <code>title</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSectionBase setTitle(string sTitle);

				#endregion

				#region Methods for Property titleLevel

				/// <summary>
				/// Gets current value of property {@link #getTitleLevel titleLevel}.
				/// 
				/// Determines the ARIA level of the <code>ObjectPageSectionBase</code> title. The ARIA level is used by assisting technologies, such as screen readers, to create a hierarchical site map for faster navigation.
				/// 
				/// <b>Note:</b> Defining a <code>titleLevel</code> will add <code>aria-level</code> attribute from 1 to 6, instead of changing the <code>ObjectPageSectionBase</code> title HTML tag from H1 to H6. <br>For example: if <code>titleLevel</code> is <code>TitleLevel.H1</code>, it will result as aria-level of 1 added to the <code>ObjectPageSectionBase</code> title.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>titleLevel</code></returns>
				public extern virtual sap.ui.core.TitleLevel getTitleLevel();

				/// <summary>
				/// Sets a new value for property {@link #getTitleLevel titleLevel}.
				/// 
				/// Determines the ARIA level of the <code>ObjectPageSectionBase</code> title. The ARIA level is used by assisting technologies, such as screen readers, to create a hierarchical site map for faster navigation.
				/// 
				/// <b>Note:</b> Defining a <code>titleLevel</code> will add <code>aria-level</code> attribute from 1 to 6, instead of changing the <code>ObjectPageSectionBase</code> title HTML tag from H1 to H6. <br>For example: if <code>titleLevel</code> is <code>TitleLevel.H1</code>, it will result as aria-level of 1 added to the <code>ObjectPageSectionBase</code> title.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sTitleLevel">New value for property <code>titleLevel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSectionBase setTitleLevel(sap.ui.core.TitleLevel sTitleLevel);

				#endregion

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Invisible ObjectPageSectionBase are not rendered
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern override bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Invisible ObjectPageSectionBase are not rendered
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSectionBase setVisible(bool bVisible);

				#endregion

				#region Methods for Property importance

				/// <summary>
				/// Gets current value of property {@link #getImportance importance}.
				/// 
				/// Determines whether the section will be hidden on low resolutions.
				/// 
				/// Default value is <code>High</code>.
				/// </summary>
				/// <returns>Value of property <code>importance</code></returns>
				public extern virtual sap.uxap.Importance getImportance();

				/// <summary>
				/// Sets a new value for property {@link #getImportance importance}.
				/// 
				/// Determines whether the section will be hidden on low resolutions.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>High</code>.
				/// </summary>
				/// <param name="sImportance">New value for property <code>importance</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSectionBase setImportance(sap.uxap.Importance sImportance);

				#endregion

				#region Methods for Aggregation customAnchorBarButton

				/// <summary>
				/// Gets content of aggregation {@link #getCustomAnchorBarButton customAnchorBarButton}.
				/// 
				/// The custom button that will provide a link to the section in the ObjectPageLayout anchor bar. This button will be used as a custom template to be into the ObjectPageLayout anchorBar area, therefore property changes happening on this button template after the first rendering won't affect the actual button copy used in the anchorBar.
				/// 
				/// If you want to change some of the button properties, you would need to bind them to a model.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Button getCustomAnchorBarButton();

				/// <summary>
				/// Destroys the customAnchorBarButton in the aggregation {@link #getCustomAnchorBarButton customAnchorBarButton}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSectionBase destroyCustomAnchorBarButton();

				/// <summary>
				/// Sets the aggregated {@link #getCustomAnchorBarButton customAnchorBarButton}.
				/// </summary>
				/// <param name="oCustomAnchorBarButton">The customAnchorBarButton to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageSectionBase setCustomAnchorBarButton(sap.m.Button oCustomAnchorBarButton);

				#endregion

				#region Other methods

				/// <summary>
				/// Explicitly ask to connect to the UI5 model tree
				/// </summary>
				public extern virtual void connectToModels();

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageSectionBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageSectionBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageSectionBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageSectionBase.
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
