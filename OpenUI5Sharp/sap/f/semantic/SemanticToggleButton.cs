using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class f
		{
			public static partial class semantic
			{
				/// <summary>
				/// A base class for the {@link sap.f.semantic.FavoriteAction} and {@link sap.f.semantic.FlagAction}.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.f.semantic.SemanticToggleButton")]
				public abstract partial class SemanticToggleButton : sap.f.semantic.SemanticButton
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.f.semantic.SemanticButton.Settings
					{
						/// <summary>
						/// Defines the <code>SemanticToggleButton</code> pressed state.
						/// 
						/// The property is set to <code>true</code> when the control is toggled (default is <code>false</code>).
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> pressed;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>SemanticToggleButton</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern SemanticToggleButton(string sId, sap.f.semantic.SemanticToggleButton.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>SemanticToggleButton</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern SemanticToggleButton(string sId);

					/// <summary>
					/// Constructor for a new <code>SemanticToggleButton</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern SemanticToggleButton();

					/// <summary>
					/// Constructor for a new <code>SemanticToggleButton</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern SemanticToggleButton(sap.f.semantic.SemanticToggleButton.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property pressed

					/// <summary>
					/// Gets current value of property {@link #getPressed pressed}.
					/// 
					/// Defines the <code>SemanticToggleButton</code> pressed state.
					/// 
					/// The property is set to <code>true</code> when the control is toggled (default is <code>false</code>).
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>pressed</code></returns>
					public extern virtual bool getPressed();

					/// <summary>
					/// Sets a new value for property {@link #getPressed pressed}.
					/// 
					/// Defines the <code>SemanticToggleButton</code> pressed state.
					/// 
					/// The property is set to <code>true</code> when the control is toggled (default is <code>false</code>).
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bPressed">New value for property <code>pressed</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.f.semantic.SemanticToggleButton setPressed(bool bPressed);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.f.semantic.SemanticToggleButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.f.semantic.SemanticToggleButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.f.semantic.SemanticToggleButton with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.f.semantic.SemanticButton.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.f.semantic.SemanticToggleButton.
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
