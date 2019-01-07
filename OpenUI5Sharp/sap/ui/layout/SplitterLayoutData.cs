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
			public static partial class layout
			{
				/// <summary>
				/// Holds layout data for the splitter contents. Allowed size values are numeric values ending in "px" and "%" and the special case "auto". (The CSS value "auto" is used internally to recalculate the size of the content dynamically and is not directly set as style property.)
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.layout.SplitterLayoutData")]
				public partial class SplitterLayoutData : sap.ui.core.LayoutData
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
						/// Determines whether the control in the splitter can be resized or not.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> resizable;

						/// <summary>
						/// Sets the size of the splitter content.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> size;

						/// <summary>
						/// Sets the minimum size of the splitter content in px.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minSize;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new SplitterLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SplitterLayoutData(string sId, sap.ui.layout.SplitterLayoutData.Settings mSettings);

					/// <summary>
					/// Constructor for a new SplitterLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern SplitterLayoutData(string sId);

					/// <summary>
					/// Constructor for a new SplitterLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern SplitterLayoutData();

					/// <summary>
					/// Constructor for a new SplitterLayoutData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SplitterLayoutData(sap.ui.layout.SplitterLayoutData.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property resizable

					/// <summary>
					/// Gets current value of property {@link #getResizable resizable}.
					/// 
					/// Determines whether the control in the splitter can be resized or not.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>resizable</code></returns>
					public extern virtual bool getResizable();

					/// <summary>
					/// Sets a new value for property {@link #getResizable resizable}.
					/// 
					/// Determines whether the control in the splitter can be resized or not.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bResizable">New value for property <code>resizable</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.SplitterLayoutData setResizable(bool bResizable);

					#endregion

					#region Methods for Property size

					/// <summary>
					/// Gets current value of property {@link #getSize size}.
					/// 
					/// Sets the size of the splitter content.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <returns>Value of property <code>size</code></returns>
					public extern virtual sap.ui.core.CSSSize getSize();

					/// <summary>
					/// Sets a new value for property {@link #getSize size}.
					/// 
					/// Sets the size of the splitter content.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <param name="sSize">New value for property <code>size</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.SplitterLayoutData setSize(sap.ui.core.CSSSize sSize);

					#endregion

					#region Methods for Property minSize

					/// <summary>
					/// Gets current value of property {@link #getMinSize minSize}.
					/// 
					/// Sets the minimum size of the splitter content in px.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>minSize</code></returns>
					public extern virtual int getMinSize();

					/// <summary>
					/// Sets a new value for property {@link #getMinSize minSize}.
					/// 
					/// Sets the minimum size of the splitter content in px.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="iMinSize">New value for property <code>minSize</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.SplitterLayoutData setMinSize(int iMinSize);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.SplitterLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.SplitterLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.SplitterLayoutData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.SplitterLayoutData.
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
