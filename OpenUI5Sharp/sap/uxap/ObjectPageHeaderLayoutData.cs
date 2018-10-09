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
			/// A {@link sap.ui.core.LayoutData} element that can be added to controls used in the <code>headerContent</code> aggregation of the <code>ObjectPageLayout</code>.
			/// 
			/// <b>Note:</b> This element is only taken into account when the <code>sap.uxap.ObjectPageLayout</code> control is used together with <code>sap.uxap.ObjectPageHeader</code> as value of <code>headerTitle</code>.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageHeaderLayoutData")]
			public partial class ObjectPageHeaderLayoutData : sap.ui.core.LayoutData
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.LayoutData.Settings
				{
					/// <summary>
					/// If this property is set the control will be visible (or not) in a small sized layout.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleS;

					/// <summary>
					/// If this property is set the control will be visible (or not) in a medium sized layout.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleM;

					/// <summary>
					/// If this property is set the control will be visible (or not) in a large sized layout.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleL;

					/// <summary>
					/// If this property is set the control will display a separator before it.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSeparatorBefore;

					/// <summary>
					/// If this property is set the control will display a separator after it.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSeparatorAfter;

					/// <summary>
					/// If this property is set the control will take the provided size.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageHeaderLayoutData(string sId, sap.uxap.ObjectPageHeaderLayoutData.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ObjectPageHeaderLayoutData(string sId);

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ObjectPageHeaderLayoutData();

				/// <summary>
				/// Constructor for a new <code>ObjectPageHeaderLayoutData</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ObjectPageHeaderLayoutData(sap.uxap.ObjectPageHeaderLayoutData.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property visibleS

				/// <summary>
				/// Gets current value of property {@link #getVisibleS visibleS}.
				/// 
				/// If this property is set the control will be visible (or not) in a small sized layout.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visibleS</code></returns>
				public extern virtual bool getVisibleS();

				/// <summary>
				/// Sets a new value for property {@link #getVisibleS visibleS}.
				/// 
				/// If this property is set the control will be visible (or not) in a small sized layout.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisibleS">New value for property <code>visibleS</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderLayoutData setVisibleS(bool bVisibleS);

				#endregion

				#region Methods for Property visibleM

				/// <summary>
				/// Gets current value of property {@link #getVisibleM visibleM}.
				/// 
				/// If this property is set the control will be visible (or not) in a medium sized layout.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visibleM</code></returns>
				public extern virtual bool getVisibleM();

				/// <summary>
				/// Sets a new value for property {@link #getVisibleM visibleM}.
				/// 
				/// If this property is set the control will be visible (or not) in a medium sized layout.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisibleM">New value for property <code>visibleM</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderLayoutData setVisibleM(bool bVisibleM);

				#endregion

				#region Methods for Property visibleL

				/// <summary>
				/// Gets current value of property {@link #getVisibleL visibleL}.
				/// 
				/// If this property is set the control will be visible (or not) in a large sized layout.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visibleL</code></returns>
				public extern virtual bool getVisibleL();

				/// <summary>
				/// Sets a new value for property {@link #getVisibleL visibleL}.
				/// 
				/// If this property is set the control will be visible (or not) in a large sized layout.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisibleL">New value for property <code>visibleL</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderLayoutData setVisibleL(bool bVisibleL);

				#endregion

				#region Methods for Property showSeparatorBefore

				/// <summary>
				/// Gets current value of property {@link #getShowSeparatorBefore showSeparatorBefore}.
				/// 
				/// If this property is set the control will display a separator before it.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showSeparatorBefore</code></returns>
				public extern virtual bool getShowSeparatorBefore();

				/// <summary>
				/// Sets a new value for property {@link #getShowSeparatorBefore showSeparatorBefore}.
				/// 
				/// If this property is set the control will display a separator before it.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowSeparatorBefore">New value for property <code>showSeparatorBefore</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderLayoutData setShowSeparatorBefore(bool bShowSeparatorBefore);

				#endregion

				#region Methods for Property showSeparatorAfter

				/// <summary>
				/// Gets current value of property {@link #getShowSeparatorAfter showSeparatorAfter}.
				/// 
				/// If this property is set the control will display a separator after it.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showSeparatorAfter</code></returns>
				public extern virtual bool getShowSeparatorAfter();

				/// <summary>
				/// Sets a new value for property {@link #getShowSeparatorAfter showSeparatorAfter}.
				/// 
				/// If this property is set the control will display a separator after it.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowSeparatorAfter">New value for property <code>showSeparatorAfter</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderLayoutData setShowSeparatorAfter(bool bShowSeparatorAfter);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// If this property is set the control will take the provided size.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// If this property is set the control will take the provided size.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>auto</code>.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.uxap.ObjectPageHeaderLayoutData setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeaderLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeaderLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.uxap.ObjectPageHeaderLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.uxap.ObjectPageHeaderLayoutData.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
