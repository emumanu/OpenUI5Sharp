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
				/// Represents a title element that can be used for aggregation with other controls
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.Title")]
				[Obsolete("Deprecated since 1.16.0. moved to sap.ui.core library. Please use this one.")]
				public partial class Title : sap.ui.core.Title
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.Title.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Title.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Title(string sId, sap.ui.commons.Title.Settings mSettings);

					/// <summary>
					/// Constructor for a new Title.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Title(string sId);

					/// <summary>
					/// Constructor for a new Title.
					/// </summary>
					public extern Title();

					/// <summary>
					/// Constructor for a new Title.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Title(sap.ui.commons.Title.Settings mSettings);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Title with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Title.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Title with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Title.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.Title with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Title.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Getter for property <code>level</code>. Defines the level of the title. If set to auto the level of the title is chosen by the control rendering the title.
					/// 
					/// Currently not all controls using the Title.control supporting this property.
					/// 
					/// Default value is <code>Auto</code>
					/// </summary>
					/// <returns>the value of property <code>level</code></returns>
					public extern virtual object getLevel();

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.Title.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Setter for property <code>level</code>.
					/// 
					/// Default value is <code>Auto</code>
					/// </summary>
					/// <param name="oLevel">new value for property <code>level</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.Title setLevel(object oLevel);

					#endregion

				}
			}
		}
	}
}
