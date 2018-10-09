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
			/// <h3>Overview</h3> A multi-input field allows the user to enter multiple values, which are displayed as {@link sap.m.Token tokens}. These can be displayed in single and multi-line mode. You can enable auto-complete suggestions or value help to help the user choose the correct entry. You can define validator functions to define what token values are accepted. <b>Notes:</b> <ul> <li> New valid tokens are created, when the user presses Enter, selects a value from the suggestions drop-down, or when the focus leaves the field.</li> <li> Provide meaningful labels for all input fields. Do not use the placeholder as a replacement for the label.</li> </ul> <h3>Usage</h3> <h4>When to use:</h4> <ul> <li> You need to provide the value help option to help users select or search multiple business objects.</li> <li> The dataset to choose from is expected to increase over time (for example, to more than 200 values).</li> </ul> <h4>When not to use:</h4> <ul> <li> Do not use multi-line inputs in tables and forms.</li> <li> When you need to select only one value.</li> <li> When you want the user to select from a predefined set of options. Use {@link sap.m.MultiComboBox} instead.</li> </ul> <h3>Responsive Behavior</h3> <u>On Phones:</u> <ul> <li> Only the last entered token is displayed.</li> <li> A new full-screen dialog opens where the auto-complete suggestions can be selected.</li> <li> You can review the tokens by tapping on the token or the input field.</li> </ul> <u> On Tablets:</u> <ul> <li> The auto-complete suggestions appear below or above the multi-input field.</li> <li> You can review the tokens by swiping them to the left or right.</li> <li> (Multi-line Mode) Previously added tokens are visible above the input field.</li> </ul> <u>On Desktop:</u> <ul> <li> The auto-complete suggestions appear below or above the multi-input field.</li> <li> You can review the tokens by pressing the right or left arrows on the keyboard.</li> <li> You can select single tokens or a range of tokens and you can copy/cut/delete them.</ <li> (Multi-line Mode) Previously added tokens are visible above the input field.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MultiInput")]
			public partial class MultiInput : sap.m.Input
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.Input.Settings
				{
					/// <summary>
					/// If set to true, the MultiInput will be displayed in multi-line display mode. In multi-line display mode, all tokens can be fully viewed and easily edited in the MultiInput. The default value is false. <b>Note:</b> This property does not take effect on smartphones or when the editable property is set to false. <b>Caution:</b> Do not enable multi-line mode in tables and forms.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> enableMultiLineMode;

					/// <summary>
					/// The max number of tokens that is allowed in MultiInput.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxTokens;

					/// <summary>
					/// The currently displayed tokens
					/// </summary>
					public Union<sap.m.Token[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> tokens;

					/// <summary>
					/// Fired when the tokens aggregation changed (add / remove token)
					/// </summary>
					public sap.m.TokenChangeDelegate tokenChange;

					/// <summary>
					/// Fired when the tokens aggregation changed due to a user interaction (add / remove token)
					/// </summary>
					public sap.m.TokenUpdateDelegate tokenUpdate;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MultiInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MultiInput(string sId, sap.m.MultiInput.Settings mSettings);

				/// <summary>
				/// Constructor for a new MultiInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern MultiInput(string sId);

				/// <summary>
				/// Constructor for a new MultiInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern MultiInput();

				/// <summary>
				/// Constructor for a new MultiInput.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern MultiInput(sap.m.MultiInput.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property enableMultiLineMode

				/// <summary>
				/// Gets current value of property {@link #getEnableMultiLineMode enableMultiLineMode}.
				/// 
				/// If set to true, the MultiInput will be displayed in multi-line display mode. In multi-line display mode, all tokens can be fully viewed and easily edited in the MultiInput. The default value is false. <b>Note:</b> This property does not take effect on smartphones or when the editable property is set to false. <b>Caution:</b> Do not enable multi-line mode in tables and forms.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>enableMultiLineMode</code></returns>
				public extern virtual bool getEnableMultiLineMode();

				/// <summary>
				/// Setter for property <code>enableMultiLineMode</code>.
				/// </summary>
				/// <param name="bMultiLineMode">Property value</param>
				/// <returns>Pointer to the control instance for chaining</returns>
				public extern virtual sap.m.MultiInput setEnableMultiLineMode(bool bMultiLineMode);

				#endregion

				#region Methods for Property maxTokens

				/// <summary>
				/// Gets current value of property {@link #getMaxTokens maxTokens}.
				/// 
				/// The max number of tokens that is allowed in MultiInput.
				/// </summary>
				/// <returns>Value of property <code>maxTokens</code></returns>
				public extern virtual int getMaxTokens();

				/// <summary>
				/// Sets a new value for property {@link #getMaxTokens maxTokens}.
				/// 
				/// The max number of tokens that is allowed in MultiInput.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iMaxTokens">New value for property <code>maxTokens</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiInput setMaxTokens(int iMaxTokens);

				#endregion

				#region Methods for Aggregation tokens

				/// <summary>
				/// Gets content of aggregation {@link #getTokens tokens}.
				/// 
				/// The currently displayed tokens
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Token[] getTokens();

				/// <summary>
				/// Destroys all the tokens in the aggregation {@link #getTokens tokens}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiInput destroyTokens();

				/// <summary>
				/// Inserts a token into the aggregation {@link #getTokens tokens}.
				/// </summary>
				/// <param name="oToken">The token to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the token should be inserted at; for a negative value of <code>iIndex</code>, the token is inserted at position 0; for a value greater than the current size of the aggregation, the token is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiInput insertToken(sap.m.Token oToken, int iIndex);

				/// <summary>
				/// Adds some token to the aggregation {@link #getTokens tokens}.
				/// </summary>
				/// <param name="oToken">The token to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiInput addToken(sap.m.Token oToken);

				/// <summary>
				/// Removes a token from the aggregation {@link #getTokens tokens}.
				/// </summary>
				/// <param name="vToken">The token to remove or its index or id</param>
				/// <returns>The removed token or <code>null</code></returns>
				public extern virtual sap.m.Token removeToken(Union<int, string, sap.m.Token> vToken);

				/// <summary>
				/// Checks for the provided <code>sap.m.Token</code> in the aggregation {@link #getTokens tokens}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oToken">The token whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfToken(sap.m.Token oToken);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getTokens tokens}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.Token[] removeAllTokens();

				#endregion

				#region Methods for Aggregation tokenizer

				#endregion

				#region Methods for Event tokenChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenChange tokenChange} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiInput</code> itself.
				/// 
				/// Fired when the tokens aggregation changed (add / remove token)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MultiInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.46. Please use the new event tokenUpdate.")]
				public extern virtual sap.m.MultiInput attachTokenChange(object oData, sap.m.TokenChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenChange tokenChange} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiInput</code> itself.
				/// 
				/// Fired when the tokens aggregation changed (add / remove token)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.46. Please use the new event tokenUpdate.")]
				public extern virtual sap.m.MultiInput attachTokenChange(object oData, sap.m.TokenChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenChange tokenChange} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiInput</code> itself.
				/// 
				/// Fired when the tokens aggregation changed (add / remove token)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.46. Please use the new event tokenUpdate.")]
				public extern virtual sap.m.MultiInput attachTokenChange(sap.m.TokenChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenChange tokenChange} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiInput</code> itself.
				/// 
				/// Fired when the tokens aggregation changed (add / remove token)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MultiInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.46. Please use the new event tokenUpdate.")]
				public extern virtual sap.m.MultiInput attachTokenChange(sap.m.TokenChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:tokenChange tokenChange} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.46. Please use the new event tokenUpdate.")]
				public extern virtual sap.m.MultiInput detachTokenChange(sap.m.TokenChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:tokenChange tokenChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.46. Please use the new event tokenUpdate.")]
				public extern virtual sap.m.MultiInput fireTokenChange(sap.m.TokenChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:tokenChange tokenChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.46. Please use the new event tokenUpdate.")]
				public extern virtual sap.m.MultiInput fireTokenChange();

				#endregion

				#region Methods for Event tokenUpdate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiInput</code> itself.
				/// 
				/// Fired when the tokens aggregation changed due to a user interaction (add / remove token)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MultiInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiInput attachTokenUpdate(object oData, sap.m.TokenUpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiInput</code> itself.
				/// 
				/// Fired when the tokens aggregation changed due to a user interaction (add / remove token)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiInput attachTokenUpdate(object oData, sap.m.TokenUpdateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiInput</code> itself.
				/// 
				/// Fired when the tokens aggregation changed due to a user interaction (add / remove token)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiInput attachTokenUpdate(sap.m.TokenUpdateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.MultiInput</code> itself.
				/// 
				/// Fired when the tokens aggregation changed due to a user interaction (add / remove token)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.MultiInput</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiInput attachTokenUpdate(sap.m.TokenUpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.MultiInput</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.MultiInput detachTokenUpdate(sap.m.TokenUpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:tokenUpdate tokenUpdate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireTokenUpdate(sap.m.TokenUpdateInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:tokenUpdate tokenUpdate} to attached listeners.
				/// 
				/// Listeners may prevent the default action of this event by using the <code>preventDefault</code>-method on the event object.
				/// </summary>
				/// <returns>Whether or not to prevent the default action</returns>
				public extern virtual bool fireTokenUpdate();

				#endregion

				#region Other methods

				/// <summary>
				/// Function adds a validation callback called before any new token gets added to the tokens aggregation
				/// </summary>
				/// <param name="fValidator">The validation callback</param>
				public extern virtual void addValidator(object fValidator);

				/// <summary>
				/// Function overwrites clone function to add tokens to MultiInput
				/// </summary>
				/// <returns>reference to the newly created clone</returns>
				public extern virtual sap.ui.core.Element clone();

				/// <summary>
				/// Close multi-line MultiInput in multi-line mode
				/// </summary>
				public extern virtual void closeMultiLine();

				/// <summary>
				/// Creates a new subclass of class sap.m.MultiInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Input.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MultiInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Input.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MultiInput with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.Input.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <returns>The accessibility object</returns>
				public extern override object getAccessibilityInfo();

				/// <summary>
				/// Get the reference element which the message popup should dock to
				/// </summary>
				/// <returns>Dom Element which the message popup should dock to</returns>
				public extern virtual dom.HTMLElement getDomRefForValueStateMessage();

				/// <summary>
				/// Returns a metadata object for class sap.m.MultiInput.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Function returns domref which acts as reference point for the opening suggestion menu
				/// </summary>
				/// <returns>The domref at which to open the suggestion menu</returns>
				public extern virtual dom.HTMLElement getPopupAnchorDomRef();

				/// <summary>
				/// Focus is on MultiInput
				/// </summary>
				/// <param name="oEvent">The event object</param>
				public extern override void onfocusin(jquery.JQuery.Event oEvent);

				/// <summary>
				/// When press ESC, deselect all tokens and all texts
				/// </summary>
				/// <param name="oEvent">The event object</param>
				public extern override void onsapescape(jquery.JQuery.Event oEvent);

				/// <summary>
				/// When tap on text field, deselect all tokens
				/// </summary>
				/// <param name="oEvent">The event object</param>
				public extern override void ontap(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Expand multi-line MultiInput in multi-line mode
				/// </summary>
				public extern virtual void openMultiLine();

				/// <summary>
				/// Function removes all validation callbacks
				/// </summary>
				public extern virtual void removeAllValidators();

				/// <summary>
				/// Function removes a validation callback
				/// </summary>
				/// <param name="fValidator">The validation callback to be removed</param>
				public extern virtual void removeValidator(object fValidator);

				/// <summary>
				/// Function sets an array of tokens, existing tokens will get overridden
				/// </summary>
				/// <param name="aTokens">The new token set</param>
				/// <returns>Pointer to the control instance for chaining</returns>
				public extern virtual sap.m.MultiInput setTokens(sap.m.Token[] aTokens);

				/// <summary>
				/// Updates the inner input field.
				/// </summary>
				public extern override void updateInputField();

				#endregion

				#endregion

			}
		}
	}
}
