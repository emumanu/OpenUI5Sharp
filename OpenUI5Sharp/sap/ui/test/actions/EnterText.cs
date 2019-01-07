using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class test
			{
				public static partial class actions
				{
					[External]
					[Namespace(false)]
					[Name("sap.ui.test.actions.EnterText")]
					public partial class EnterText : sap.ui.test.actions.Action
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.test.actions.Action.Settings
						{
							/// <summary>
							/// The Text that is going to be typed to the control. If you are entering an empty string, the value will be cleared.
							/// </summary>
							public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

							public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> clearTextFirst;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// The EnterText action is used to simulate a user entering texts to inputs. EnterText will be executed on a control's focus dom ref. Supported controls are (for other controls this action still might work): <ul> <li>sap.m.Input</li> <li>sap.m.SearchField</li> <li>sap.m.TextArea</li> </ul>
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern EnterText();

						#endregion

						#region Methods

						#region Methods for Property text

						/// <summary>
						/// Gets current value of property {@link #getText text}.
						/// 
						/// The Text that is going to be typed to the control. If you are entering an empty string, the value will be cleared.
						/// </summary>
						/// <returns>Value of property <code>text</code></returns>
						public extern virtual string getText();

						/// <summary>
						/// Sets a new value for property {@link #getText text}.
						/// 
						/// The Text that is going to be typed to the control. If you are entering an empty string, the value will be cleared.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sText">New value for property <code>text</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.actions.EnterText setText(string sText);

						#endregion

						#region Methods for Property clearTextFirst

						/// <summary>
						/// Gets current value of property {@link #getClearTextFirst clearTextFirst}.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>clearTextFirst</code></returns>
						public extern virtual bool getClearTextFirst();

						/// <summary>
						/// Sets a new value for property {@link #getClearTextFirst clearTextFirst}.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <param name="bClearTextFirst">New value for property <code>clearTextFirst</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.test.actions.EnterText setClearTextFirst(bool bClearTextFirst);

						#endregion

						#region Other methods

						/// <summary>
						/// Sets focus on given control and triggers Multiple keyboard events on it, one event for every character in the text. Logs an error if control has no focusable dom ref or is not visible.
						/// </summary>
						/// <param name="oControl">the control on which the text event should be entered in.</param>
						public extern virtual void executeOn(sap.ui.core.Control oControl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.actions.EnterText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.actions.Action.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.actions.EnterText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.actions.Action.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.test.actions.EnterText with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.test.actions.Action.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.test.actions.EnterText.
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
}
