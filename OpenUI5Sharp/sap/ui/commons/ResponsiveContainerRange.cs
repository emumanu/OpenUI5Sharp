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
			public static partial class commons
			{
				/// <summary>
				/// Defines a range for the ResponsiveContainer
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ResponsiveContainerRange")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class ResponsiveContainerRange : sap.ui.core.Element
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
						/// The minimal width for this range to be displayed.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// The minimal height for this range to be displayed.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// A key which can be used to identify the range (optional).
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> key;

						/// <summary>
						/// The content to show for this range (optional).
						/// </summary>
						public Union<sap.ui.core.Control, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> content;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ResponsiveContainerRange.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ResponsiveContainerRange(string sId, sap.ui.commons.ResponsiveContainerRange.Settings mSettings);

					/// <summary>
					/// Constructor for a new ResponsiveContainerRange.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ResponsiveContainerRange(string sId);

					/// <summary>
					/// Constructor for a new ResponsiveContainerRange.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ResponsiveContainerRange();

					/// <summary>
					/// Constructor for a new ResponsiveContainerRange.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ResponsiveContainerRange(sap.ui.commons.ResponsiveContainerRange.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// The minimal width for this range to be displayed.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// Sets a new value for property {@link #getWidth width}.
					/// 
					/// The minimal width for this range to be displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sWidth">New value for property <code>width</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainerRange setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// The minimal height for this range to be displayed.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// The minimal height for this range to be displayed.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainerRange setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property key

					/// <summary>
					/// Gets current value of property {@link #getKey key}.
					/// 
					/// A key which can be used to identify the range (optional).
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>key</code></returns>
					public extern virtual string getKey();

					/// <summary>
					/// Sets a new value for property {@link #getKey key}.
					/// 
					/// A key which can be used to identify the range (optional).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sKey">New value for property <code>key</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainerRange setKey(string sKey);

					#endregion

					#region Methods for Association content

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getContent content}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getContent();

					/// <summary>
					/// Sets the associated {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">ID of an element which becomes the new target of this content association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ResponsiveContainerRange setContent(Union<sap.ui.core.ID, sap.ui.core.Control> oContent);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ResponsiveContainerRange with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ResponsiveContainerRange with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ResponsiveContainerRange with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ResponsiveContainerRange.
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
