﻿using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class m
		{
			public static partial class semantic
			{
				/// <summary>
				/// A semantic control is an abstraction for either a {@link sap.m.semantic.SemanticButton} or {@link sap.m.semantic.SemanticSelect} , eligible for aggregation content of a {@link sap.m.semantic.SemanticPage}.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.m.semantic.SemanticControl")]
				public abstract partial class SemanticControl : sap.ui.core.Element
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
						/// See {@link sap.ui.core.Control#visible}
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new SemanticControl.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SemanticControl(string sId, sap.m.semantic.SemanticControl.Settings mSettings);

					/// <summary>
					/// Constructor for a new SemanticControl.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern SemanticControl(string sId);

					/// <summary>
					/// Constructor for a new SemanticControl.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern SemanticControl();

					/// <summary>
					/// Constructor for a new SemanticControl.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern SemanticControl(sap.m.semantic.SemanticControl.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// See {@link sap.ui.core.Control#visible}
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern virtual bool getVisible();

					/// <summary>
					/// Sets a new value for property {@link #getVisible visible}.
					/// 
					/// See {@link sap.ui.core.Control#visible}
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.m.semantic.SemanticControl setVisible(bool bVisible);

					#endregion

					#region Methods for Aggregation _control

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SemanticControl with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SemanticControl with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.semantic.SemanticControl with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.m.semantic.SemanticControl.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Implementation of a commonly used function that adapts <code>sap.ui.core.Element</code> to provide DOM reference for opening popovers.
					/// </summary>
					/// <returns>The DOM reference of the actual wrapped control</returns>
					public extern virtual void getPopupAnchorDomRef();

					#endregion

					#endregion

				}
			}
		}
	}
}
