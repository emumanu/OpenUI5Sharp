using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class unified
			{
				/// <summary>
				/// A text view which displays currency values and aligns them at the decimal point.
				/// 
				/// <h3>Overview</h3>
				/// 
				/// The currency control consists of an amount, which is formatted automatically according to the user’s locale (using delimiter symbols for the decimal point and thousand separators) and to the currency set for this specific number (number of decimal places).
				/// 
				/// The currency is expressed as a three-letter code.
				/// 
				/// <h3>Usage</h3>
				/// 
				/// <i>When to use</i> <ul> <li>To display amounts with different currencies in a vertical layout, such as in a table, list, or form, and it is important that the user is able to compare the amounts.</li> </ul>
				/// 
				/// <i>When not to use</i> <ul> <li>To display amounts with the same currency in a table. Use the {@link sap.m.ObjectNumber} instead.</li> <li>to display a number with a unit of measurement that is not a currency. Use the {@link sap.m.ObjectNumber} instead.</li> <li>To display an amount in a structure other than a list, table, or form.</li> </ul>
				/// 
				/// <h3>Responsive behavior</h3>
				/// 
				/// The control supports amounts smaller than 100 trillion, which still fit on a phone screen in portrait mode. For larger amounts, the unit of measurement wraps to the next line, which makes it difficult to compare the amounts.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class Currency : sap.ui.core.Control
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
						/// Determines the currency value.
						/// </summary>
						public Union<float, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> value;

						/// <summary>
						/// Determines the currency value as a string.
						/// 
						/// String value is useful if you want to store really big values. If there are more than 21 digits before the decimal point or if the number starts with “0.” followed by more than five zeros, it is represented in exponential form. In these cases use the <code>stringValue</code> property to keep the number in decimal format.
						/// 
						/// <b>Note:</b> If set, it will take precedence over the <code>value</code> property.
						/// </summary>
						public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> stringValue;

						/// <summary>
						/// Determines the displayed currency code (ISO 4217).
						/// 
						/// <b>Note:</b> If a * character is set instead of currency code, only the character itself will be rendered, ignoring the <code>value</code> property.
						/// </summary>
						public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> currency;

						/// <summary>
						/// Defines the space that is available for the precision of the various currencies.
						/// </summary>
						public Union<int, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> maxPrecision;

						/// <summary>
						/// Displays the currency symbol instead of the ISO currency code.
						/// </summary>
						public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> useSymbol;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new <code>Currency</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Currency(string sId, sap.ui.unified.Currency.Settings mSettings);

					/// <summary>
					/// Constructor for a new <code>Currency</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern Currency(string sId);

					/// <summary>
					/// Constructor for a new <code>Currency</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Currency();

					/// <summary>
					/// Constructor for a new <code>Currency</code>.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern Currency(sap.ui.unified.Currency.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property value

					/// <summary>
					/// Gets current value of property {@link #getValue value}.
					/// 
					/// Determines the currency value.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <returns>Value of property <code>value</code></returns>
					public extern virtual float getValue();

					/// <summary>
					/// Sets a new value for property {@link #getValue value}.
					/// 
					/// Determines the currency value.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>0</code>.
					/// </summary>
					/// <param name="fValue">New value for property <code>value</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Currency setValue(float fValue);

					#endregion

					#region Methods for Property stringValue

					/// <summary>
					/// Gets current value of property {@link #getStringValue stringValue}.
					/// 
					/// Determines the currency value as a string.
					/// 
					/// String value is useful if you want to store really big values. If there are more than 21 digits before the decimal point or if the number starts with “0.” followed by more than five zeros, it is represented in exponential form. In these cases use the <code>stringValue</code> property to keep the number in decimal format.
					/// 
					/// <b>Note:</b> If set, it will take precedence over the <code>value</code> property.
					/// </summary>
					/// <returns>Value of property <code>stringValue</code></returns>
					public extern virtual string getStringValue();

					/// <summary>
					/// Sets a new value for property {@link #getStringValue stringValue}.
					/// 
					/// Determines the currency value as a string.
					/// 
					/// String value is useful if you want to store really big values. If there are more than 21 digits before the decimal point or if the number starts with “0.” followed by more than five zeros, it is represented in exponential form. In these cases use the <code>stringValue</code> property to keep the number in decimal format.
					/// 
					/// <b>Note:</b> If set, it will take precedence over the <code>value</code> property.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sStringValue">New value for property <code>stringValue</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Currency setStringValue(string sStringValue);

					#endregion

					#region Methods for Property currency

					/// <summary>
					/// Gets current value of property {@link #getCurrency currency}.
					/// 
					/// Determines the displayed currency code (ISO 4217).
					/// 
					/// <b>Note:</b> If a * character is set instead of currency code, only the character itself will be rendered, ignoring the <code>value</code> property.
					/// </summary>
					/// <returns>Value of property <code>currency</code></returns>
					public extern virtual string getCurrency();

					/// <summary>
					/// Sets a new value for property {@link #getCurrency currency}.
					/// 
					/// Determines the displayed currency code (ISO 4217).
					/// 
					/// <b>Note:</b> If a * character is set instead of currency code, only the character itself will be rendered, ignoring the <code>value</code> property.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sCurrency">New value for property <code>currency</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Currency setCurrency(string sCurrency);

					#endregion

					#region Methods for Property maxPrecision

					/// <summary>
					/// Gets current value of property {@link #getMaxPrecision maxPrecision}.
					/// 
					/// Defines the space that is available for the precision of the various currencies.
					/// 
					/// Default value is <code>3</code>.
					/// </summary>
					/// <returns>Value of property <code>maxPrecision</code></returns>
					public extern virtual int getMaxPrecision();

					/// <summary>
					/// Sets a new value for property {@link #getMaxPrecision maxPrecision}.
					/// 
					/// Defines the space that is available for the precision of the various currencies.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>3</code>.
					/// </summary>
					/// <param name="iMaxPrecision">New value for property <code>maxPrecision</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Currency setMaxPrecision(int iMaxPrecision);

					#endregion

					#region Methods for Property useSymbol

					/// <summary>
					/// Gets current value of property {@link #getUseSymbol useSymbol}.
					/// 
					/// Displays the currency symbol instead of the ISO currency code.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>useSymbol</code></returns>
					public extern virtual bool getUseSymbol();

					/// <summary>
					/// Sets a new value for property {@link #getUseSymbol useSymbol}.
					/// 
					/// Displays the currency symbol instead of the ISO currency code.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bUseSymbol">New value for property <code>useSymbol</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.unified.Currency setUseSymbol(bool bUseSymbol);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Currency with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Currency with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.unified.Currency with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <returns>Current accessibility state of the control.</returns>
					public extern virtual object getAccessibilityInfo();

					/// <summary>
					/// Get symbol of the currency, if available.
					/// </summary>
					/// <returns></returns>
					public extern virtual string getCurrencySymbol();

					/// <summary>
					/// The formatted value.
					/// </summary>
					/// <returns>The formatted value</returns>
					public extern virtual string getFormattedValue();

					/// <summary>
					/// Returns a metadata object for class sap.ui.unified.Currency.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Initializes the control.
					/// </summary>
					public extern override void init();

					#endregion

					#endregion

				}
			}
		}
	}
}
