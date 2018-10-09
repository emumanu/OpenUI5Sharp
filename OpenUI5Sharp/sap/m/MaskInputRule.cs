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
			/// The <code>sap.m.MaskInputRule</code> control holds the mapping of a single <code>maskFormatSymbol</code> to the regular expression <code>regex</code> that defines the allowed characters for the rule.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MaskInputRule")]
			public partial class MaskInputRule : sap.ui.core.Element
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
					/// Defines the symbol used in the mask format which will accept a certain range of characters.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> maskFormatSymbol;

					/// <summary>
					/// Defines the allowed characters as a regular expression.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> regex;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MaskInputRule.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MaskInputRule(string sId, sap.m.MaskInputRule.Settings mSettings);

				/// <summary>
				/// Constructor for a new MaskInputRule.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern MaskInputRule(string sId);

				/// <summary>
				/// Constructor for a new MaskInputRule.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MaskInputRule();

				/// <summary>
				/// Constructor for a new MaskInputRule.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MaskInputRule(sap.m.MaskInputRule.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property maskFormatSymbol

				/// <summary>
				/// Gets current value of property {@link #getMaskFormatSymbol maskFormatSymbol}.
				/// 
				/// Defines the symbol used in the mask format which will accept a certain range of characters.
				/// 
				/// Default value is <code>*</code>.
				/// </summary>
				/// <returns>Value of property <code>maskFormatSymbol</code></returns>
				public extern virtual string getMaskFormatSymbol();

				/// <summary>
				/// Sets a new value for property {@link #getMaskFormatSymbol maskFormatSymbol}.
				/// 
				/// Defines the symbol used in the mask format which will accept a certain range of characters.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>*</code>.
				/// </summary>
				/// <param name="sMaskFormatSymbol">New value for property <code>maskFormatSymbol</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MaskInputRule setMaskFormatSymbol(string sMaskFormatSymbol);

				#endregion

				#region Methods for Property regex

				/// <summary>
				/// Gets current value of property {@link #getRegex regex}.
				/// 
				/// Defines the allowed characters as a regular expression.
				/// 
				/// Default value is <code>[a-zA-Z0-9]</code>.
				/// </summary>
				/// <returns>Value of property <code>regex</code></returns>
				public extern virtual string getRegex();

				/// <summary>
				/// Sets a new value for property {@link #getRegex regex}.
				/// 
				/// Defines the allowed characters as a regular expression.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>[a-zA-Z0-9]</code>.
				/// </summary>
				/// <param name="sRegex">New value for property <code>regex</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MaskInputRule setRegex(string sRegex);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.MaskInputRule with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MaskInputRule with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MaskInputRule with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MaskInputRule.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
