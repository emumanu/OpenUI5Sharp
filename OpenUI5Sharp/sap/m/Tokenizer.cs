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
			/// <h3>Overview</h3> A tokenizer is a container for {@link sap.m.Token Tokens}. It also handles all actions associated with the tokens like adding, deleting, selecting and editing. <h3>Structure</h3> The tokens are stored in the <code>tokens</code> aggregation. The tokenizer can determine, by setting the <code>editable</code> property, whether the tokens in it are editable. Still the Token itself can determine if it is <code>editable</code>. This allows you to have non-editable Tokens in an editable Tokenizer.
			/// 
			/// <h3>Usage</h3> <h4>When to use:</h4> The tokenizer can only be used as part of {@link sap.m.MultiComboBox MultiComboBox},{@link sap.m.MultiInput MultiInput} or {@link sap.ui.comp.valuehelpdialog.ValueHelpDialog ValueHelpDialog}
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.Tokenizer")]
			public partial class Tokenizer : sap.ui.core.Control
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
					/// true if tokens shall be editable otherwise false
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> editable;

					/// <summary>
					/// Defines the width of the Tokenizer.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

					/// <summary>
					/// Defines the maximum width of the Tokenizer.
					/// </summary>
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxWidth;

					/// <summary>
					/// the currently displayed tokens
					/// </summary>
					public Union<sap.m.Token[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> tokens;

					/// <summary>
					/// Association to controls / ids which describe this control (see WAI-ARIA attribute aria-describedby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaDescribedBy;

					/// <summary>
					/// Association to controls / ids which label this control (see WAI-ARIA attribute aria-labelledby).
					/// </summary>
					public Union<sap.ui.core.Control, sap.ui.core.ID[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> ariaLabelledBy;

					/// <summary>
					/// fired when the tokens aggregation changed (add / remove token)
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
				/// Constructor for a new Tokenizer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Tokenizer(string sId, sap.m.Tokenizer.Settings mSettings);

				/// <summary>
				/// Constructor for a new Tokenizer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern Tokenizer(string sId);

				/// <summary>
				/// Constructor for a new Tokenizer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern Tokenizer();

				/// <summary>
				/// Constructor for a new Tokenizer.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern Tokenizer(sap.m.Tokenizer.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property editable

				/// <summary>
				/// Gets current value of property {@link #getEditable editable}.
				/// 
				/// true if tokens shall be editable otherwise false
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>editable</code></returns>
				public extern virtual bool getEditable();

				/// <summary>
				/// Sets a new value for property {@link #getEditable editable}.
				/// 
				/// true if tokens shall be editable otherwise false
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bEditable">New value for property <code>editable</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer setEditable(bool bEditable);

				#endregion

				#region Methods for Property width

				/// <summary>
				/// Gets current value of property {@link #getWidth width}.
				/// 
				/// Defines the width of the Tokenizer.
				/// </summary>
				/// <returns>Value of property <code>width</code></returns>
				public extern virtual sap.ui.core.CSSSize getWidth();

				/// <summary>
				/// Sets a new value for property {@link #getWidth width}.
				/// 
				/// Defines the width of the Tokenizer.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sWidth">New value for property <code>width</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer setWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property maxWidth

				/// <summary>
				/// Gets current value of property {@link #getMaxWidth maxWidth}.
				/// 
				/// Defines the maximum width of the Tokenizer.
				/// 
				/// Default value is <code>100%</code>.
				/// </summary>
				/// <returns>Value of property <code>maxWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getMaxWidth();

				/// <summary>
				/// Function sets the maximum width of the Tokenizer.
				/// </summary>
				/// <param name="nWidth">The new maximal width</param>
				public extern virtual void setMaxWidth(int nWidth);

				#endregion

				#region Methods for Aggregation tokens

				/// <summary>
				/// Gets content of aggregation {@link #getTokens tokens}.
				/// 
				/// the currently displayed tokens
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.Token[] getTokens();

				/// <summary>
				/// Destroys all the tokens in the aggregation {@link #getTokens tokens}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer destroyTokens();

				/// <summary>
				/// Inserts a token into the aggregation {@link #getTokens tokens}.
				/// </summary>
				/// <param name="oToken">The token to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the token should be inserted at; for a negative value of <code>iIndex</code>, the token is inserted at position 0; for a value greater than the current size of the aggregation, the token is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer insertToken(sap.m.Token oToken, int iIndex);

				/// <summary>
				/// Adds some token to the aggregation {@link #getTokens tokens}.
				/// </summary>
				/// <param name="oToken">The token to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer addToken(sap.m.Token oToken);

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

				#region Methods for Aggregation _tokensInfo

				#endregion

				#region Methods for Association ariaDescribedBy

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getAriaDescribedBy();

				/// <summary>
				/// Adds some ariaDescribedBy into the association {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <param name="vAriaDescribedBy">The ariaDescribedBy to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer addAriaDescribedBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

				/// <summary>
				/// Removes an ariaDescribedBy from the association named {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <param name="vAriaDescribedBy">The ariaDescribedBy to be removed or its index or ID</param>
				/// <returns>The removed ariaDescribedBy or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeAriaDescribedBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaDescribedBy);

				/// <summary>
				/// Removes all the controls in the association named {@link #getAriaDescribedBy ariaDescribedBy}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllAriaDescribedBy();

				#endregion

				#region Methods for Association ariaLabelledBy

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getAriaLabelledBy();

				/// <summary>
				/// Adds some ariaLabelledBy into the association {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <param name="vAriaLabelledBy">The ariaLabelledBy to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer addAriaLabelledBy(Union<sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

				/// <summary>
				/// Removes an ariaLabelledBy from the association named {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <param name="vAriaLabelledBy">The ariaLabelledBy to be removed or its index or ID</param>
				/// <returns>The removed ariaLabelledBy or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeAriaLabelledBy(Union<int, sap.ui.core.ID, sap.ui.core.Control> vAriaLabelledBy);

				/// <summary>
				/// Removes all the controls in the association named {@link #getAriaLabelledBy ariaLabelledBy}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllAriaLabelledBy();

				#endregion

				#region Methods for Event tokenChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenChange tokenChange} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tokenizer</code> itself.
				/// 
				/// fired when the tokens aggregation changed (add / remove token)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Tokenizer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer attachTokenChange(object oData, sap.m.TokenChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenChange tokenChange} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tokenizer</code> itself.
				/// 
				/// fired when the tokens aggregation changed (add / remove token)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer attachTokenChange(object oData, sap.m.TokenChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenChange tokenChange} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tokenizer</code> itself.
				/// 
				/// fired when the tokens aggregation changed (add / remove token)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer attachTokenChange(sap.m.TokenChangeDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenChange tokenChange} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tokenizer</code> itself.
				/// 
				/// fired when the tokens aggregation changed (add / remove token)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Tokenizer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer attachTokenChange(sap.m.TokenChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:tokenChange tokenChange} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer detachTokenChange(sap.m.TokenChangeDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:tokenChange tokenChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer fireTokenChange(sap.m.TokenChangeInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:tokenChange tokenChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer fireTokenChange();

				#endregion

				#region Methods for Event tokenUpdate

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tokenizer</code> itself.
				/// 
				/// Fired when the tokens aggregation changed due to a user interaction (add / remove token)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Tokenizer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer attachTokenUpdate(object oData, sap.m.TokenUpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tokenizer</code> itself.
				/// 
				/// Fired when the tokens aggregation changed due to a user interaction (add / remove token)
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer attachTokenUpdate(object oData, sap.m.TokenUpdateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tokenizer</code> itself.
				/// 
				/// Fired when the tokens aggregation changed due to a user interaction (add / remove token)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer attachTokenUpdate(sap.m.TokenUpdateDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.Tokenizer</code> itself.
				/// 
				/// Fired when the tokens aggregation changed due to a user interaction (add / remove token)
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.Tokenizer</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer attachTokenUpdate(sap.m.TokenUpdateDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:tokenUpdate tokenUpdate} event of this <code>sap.m.Tokenizer</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.Tokenizer detachTokenUpdate(sap.m.TokenUpdateDelegate fnFunction, object oListener);

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
				/// Function gets whether the tokens visibility should be adjusted
				/// </summary>
				/// <returns>If true the the tokenizer should adjust the tokens visibility</returns>
				public extern virtual bool _getAdjustable();

				/// <summary>
				/// Function returns whether the n-more indicator is visible
				/// </summary>
				/// <param name="If">true the indicator is visible</param>
				public extern virtual void _getIndicatorVisibility(bool If);

				/// <summary>
				/// Function removes all selected tokens
				/// </summary>
				/// <returns>this instance for method chaining</returns>
				public extern virtual sap.m.Tokenizer _removeSelectedTokens();

				/// <summary>
				/// Function sets whether the tokens visibility should be adjusted
				/// </summary>
				/// <param name="If">true the the tokenizer should adjust the tokens visibility</param>
				public extern virtual void _setAdjustable(bool If);

				/// <summary>
				/// Function validates the given text and adds a new token if validation was successful
				/// </summary>
				/// <param name="oParameters">parameter bag containing following fields: {sap.m.String} text - the source text {sap.m.Token} [optional] token - a suggested token {object} [optional] suggestionObject - any object used to find the suggested token {function} [optional] validationCallback - callback which gets called after validation has finished</param>
				public extern virtual void addValidateToken(object oParameters);

				/// <summary>
				/// Function adds a validation callback called before any new token gets added to the tokens aggregation
				/// </summary>
				/// <param name="fValidator">The validation function</param>
				public extern virtual void addValidator(object fValidator);

				/// <summary>
				/// Creates a new subclass of class sap.m.Tokenizer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.Tokenizer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.Tokenizer with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.Tokenizer.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Function returns the internally used scroll delegate
				/// </summary>
				/// <returns>The scroll delegate</returns>
				public extern virtual sap.ui.core.@delegate.ScrollEnablement getScrollDelegate();

				/// <summary>
				/// Function returns the tokens' width
				/// </summary>
				/// <returns>The complete width of all tokens</returns>
				public extern virtual int getScrollWidth();

				/// <summary>
				/// Function returns all currently selected tokens
				/// </summary>
				/// <returns>Array of selected tokens or empty array</returns>
				public extern virtual sap.m.Token[] getSelectedTokens();

				/// <summary>
				/// Gets the accessibility text aggregation id
				/// </summary>
				/// <returns>Returns the InvisibleText control id</returns>
				public extern virtual string getTokensInfoId();

				/// <summary>
				/// Handle the focus event on the control
				/// </summary>
				/// <param name="oEvent">The occuring event</param>
				public extern virtual void onclick(jquery.JQuery.Event oEvent);

				/// <summary>
				/// Function removes all validation callbacks
				/// </summary>
				public extern virtual void removeAllValidators();

				/// <summary>
				/// Function removes a validation callback
				/// </summary>
				/// <param name="fValidator">The validation function</param>
				public extern virtual void removeValidator(object fValidator);

				/// <summary>
				/// Function scrolls the tokens to the end
				/// </summary>
				public extern virtual void scrollToEnd();

				/// <summary>
				/// Function scrolls the tokens to the start
				/// </summary>
				public extern virtual void scrollToStart();

				/// <summary>
				/// Function selects all tokens
				/// </summary>
				/// <param name="bSelect">[optional] true for selecting, false for deselecting</param>
				/// <returns>this instance for method chaining</returns>
				public extern virtual sap.m.Tokenizer selectAllTokens(bool bSelect);

				/// <summary>
				/// Function sets the tokenizer's width in pixels
				/// </summary>
				/// <param name="nWidth">The new width in pixels</param>
				public extern virtual void setPixelWidth(int nWidth);

				#endregion

				#endregion

			}
		}
	}
}
