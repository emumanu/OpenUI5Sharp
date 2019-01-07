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
				/// Used for defining areas in an image map. At runtime, the user can trigger an action, or start a URL, from the single image areas.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Area")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class Area : sap.ui.core.Element
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
						/// The value is a string and can be 'rect' for rectangle, 'poly' for poligon, 'circle', or default.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> shape;

						/// <summary>
						/// Coordinates of the area
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> coords;

						/// <summary>
						/// Hyper link that is executed when the area is clicked
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> href;

						/// <summary>
						/// Alternative text that is displayed in the case the image is not available
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> alt;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Area.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Area(string sId, sap.ui.commons.Area.Settings mSettings);

					/// <summary>
					/// Constructor for a new Area.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Area(string sId);

					/// <summary>
					/// Constructor for a new Area.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Area();

					/// <summary>
					/// Constructor for a new Area.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Area(sap.ui.commons.Area.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property shape

					/// <summary>
					/// Gets current value of property {@link #getShape shape}.
					/// 
					/// The value is a string and can be 'rect' for rectangle, 'poly' for poligon, 'circle', or default.
					/// </summary>
					/// <returns>Value of property <code>shape</code></returns>
					public extern virtual string getShape();

					/// <summary>
					/// Sets a new value for property {@link #getShape shape}.
					/// 
					/// The value is a string and can be 'rect' for rectangle, 'poly' for poligon, 'circle', or default.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sShape">New value for property <code>shape</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Area setShape(string sShape);

					#endregion

					#region Methods for Property coords

					/// <summary>
					/// Gets current value of property {@link #getCoords coords}.
					/// 
					/// Coordinates of the area
					/// </summary>
					/// <returns>Value of property <code>coords</code></returns>
					public extern virtual string getCoords();

					/// <summary>
					/// Sets a new value for property {@link #getCoords coords}.
					/// 
					/// Coordinates of the area
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sCoords">New value for property <code>coords</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Area setCoords(string sCoords);

					#endregion

					#region Methods for Property href

					/// <summary>
					/// Gets current value of property {@link #getHref href}.
					/// 
					/// Hyper link that is executed when the area is clicked
					/// </summary>
					/// <returns>Value of property <code>href</code></returns>
					public extern virtual sap.ui.core.URI getHref();

					/// <summary>
					/// Sets a new value for property {@link #getHref href}.
					/// 
					/// Hyper link that is executed when the area is clicked
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHref">New value for property <code>href</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Area setHref(sap.ui.core.URI sHref);

					#endregion

					#region Methods for Property alt

					/// <summary>
					/// Gets current value of property {@link #getAlt alt}.
					/// 
					/// Alternative text that is displayed in the case the image is not available
					/// </summary>
					/// <returns>Value of property <code>alt</code></returns>
					public extern virtual string getAlt();

					/// <summary>
					/// Sets a new value for property {@link #getAlt alt}.
					/// 
					/// Alternative text that is displayed in the case the image is not available
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAlt">New value for property <code>alt</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.Area setAlt(string sAlt);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Area with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Area with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Area with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Area.
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
