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
			/// The <code>sap.m.MaskInput</code> control allows users to easily enter data in a certain format and in a fixed-width input (for example: date, time, phone number, credit card number, currency, IP address, MAC address, and others).
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MaskInput")]
			public partial class MaskInput : sap.m.InputBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.InputBase.Settings
				{
					/// <summary>
					/// Defines a placeholder symbol. Shown at the position where there is no user input yet.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> placeholderSymbol;

					/// <summary>
					/// Mask defined by its characters type (respectively, by its length). You should consider the following important facts: 1. The mask characters normally correspond to an existing rule (one rule per unique char). Characters which don't, are considered immutable characters (for example, the mask '2099', where '9' corresponds to a rule for digits, has the characters '2' and '0' as immutable). 2. Adding a rule corresponding to the <code>placeholderSymbol</code> is not recommended and would lead to an unpredictable behavior. 3. You can use the special escape character '^' called "Caret" prepending a rule character to make it immutable. Use the double escape '^^' if you want to make use of the escape character as an immutable one.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> mask;

					/// <summary>
					/// A list of validation rules (one rule per mask character).
					/// </summary>
					public Union<sap.m.MaskInputRule[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> rules;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MaskInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MaskInput(string sId, sap.m.MaskInput.Settings mSettings);

				/// <summary>
				/// Constructor for a new MaskInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern MaskInput(string sId);

				/// <summary>
				/// Constructor for a new MaskInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MaskInput();

				/// <summary>
				/// Constructor for a new MaskInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MaskInput(sap.m.MaskInput.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property placeholderSymbol

				/// <summary>
				/// Gets current value of property {@link #getPlaceholderSymbol placeholderSymbol}.
				/// 
				/// Defines a placeholder symbol. Shown at the position where there is no user input yet.
				/// 
				/// Default value is <code>_</code>.
				/// </summary>
				/// <returns>Value of property <code>placeholderSymbol</code></returns>
				public extern virtual string getPlaceholderSymbol();

				/// <summary>
				/// Sets a new value for property {@link #getPlaceholderSymbol placeholderSymbol}.
				/// 
				/// Defines a placeholder symbol. Shown at the position where there is no user input yet.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>_</code>.
				/// </summary>
				/// <param name="sPlaceholderSymbol">New value for property <code>placeholderSymbol</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MaskInput setPlaceholderSymbol(string sPlaceholderSymbol);

				#endregion

				#region Methods for Property mask

				/// <summary>
				/// Gets current value of property {@link #getMask mask}.
				/// 
				/// Mask defined by its characters type (respectively, by its length). You should consider the following important facts: 1. The mask characters normally correspond to an existing rule (one rule per unique char). Characters which don't, are considered immutable characters (for example, the mask '2099', where '9' corresponds to a rule for digits, has the characters '2' and '0' as immutable). 2. Adding a rule corresponding to the <code>placeholderSymbol</code> is not recommended and would lead to an unpredictable behavior. 3. You can use the special escape character '^' called "Caret" prepending a rule character to make it immutable. Use the double escape '^^' if you want to make use of the escape character as an immutable one.
				/// </summary>
				/// <returns>Value of property <code>mask</code></returns>
				public extern virtual string getMask();

				/// <summary>
				/// Sets a new value for property {@link #getMask mask}.
				/// 
				/// Mask defined by its characters type (respectively, by its length). You should consider the following important facts: 1. The mask characters normally correspond to an existing rule (one rule per unique char). Characters which don't, are considered immutable characters (for example, the mask '2099', where '9' corresponds to a rule for digits, has the characters '2' and '0' as immutable). 2. Adding a rule corresponding to the <code>placeholderSymbol</code> is not recommended and would lead to an unpredictable behavior. 3. You can use the special escape character '^' called "Caret" prepending a rule character to make it immutable. Use the double escape '^^' if you want to make use of the escape character as an immutable one.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sMask">New value for property <code>mask</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MaskInput setMask(string sMask);

				#endregion

				#region Methods for Aggregation rules

				/// <summary>
				/// Gets content of aggregation {@link #getRules rules}.
				/// 
				/// A list of validation rules (one rule per mask character).
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.MaskInputRule[] getRules();

				/// <summary>
				/// Destroys all the rules in the aggregation {@link #getRules rules}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MaskInput destroyRules();

				/// <summary>
				/// Inserts a rule into the aggregation {@link #getRules rules}.
				/// </summary>
				/// <param name="oRule">The rule to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the rule should be inserted at; for a negative value of <code>iIndex</code>, the rule is inserted at position 0; for a value greater than the current size of the aggregation, the rule is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MaskInput insertRule(sap.m.MaskInputRule oRule, int iIndex);

				/// <summary>
				/// Adds some rule to the aggregation {@link #getRules rules}.
				/// </summary>
				/// <param name="oRule">The rule to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MaskInput addRule(sap.m.MaskInputRule oRule);

				/// <summary>
				/// Removes a rule from the aggregation {@link #getRules rules}.
				/// </summary>
				/// <param name="vRule">The rule to remove or its index or id</param>
				/// <returns>The removed rule or <code>null</code></returns>
				public extern virtual sap.m.MaskInputRule removeRule(Union<int, string, sap.m.MaskInputRule> vRule);

				/// <summary>
				/// Checks for the provided <code>sap.m.MaskInputRule</code> in the aggregation {@link #getRules rules}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oRule">The rule whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfRule(sap.m.MaskInputRule oRule);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getRules rules}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.MaskInputRule[] removeAllRules();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.MaskInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MaskInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MaskInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.InputBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MaskInput.
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
