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
			/// Table Personalization Dialog
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.TablePersoDialog")]
			public partial class TablePersoDialog : sap.ui.@base.ManagedObject
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.@base.ManagedObject.Settings
				{
					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentWidth;

					public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentHeight;

					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> persoMap;

					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> columnInfoCallback;

					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> initialColumnState;

					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> hasGrouping;

					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showSelectAll;

					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showResetAll;

					/// <summary>
					/// Refers to the service for reading and writing the personalization.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindAggregationInfo> persoService;

					/// <summary>
					/// The table which shall be personalized.
					/// </summary>
					public Union<sap.m.Table, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> persoDialogFor;

					public sap.ui.@base.EventDelegate confirm;

					public sap.ui.@base.EventDelegate cancel;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// The TablePersoDialog can be used to display and allow modification of personalization settings relating to a Table. It displays the columns of the table that it refers to by using <ul><li>The result of calling sap.m.TablePersoProvider's 'getCaption' callback if it is implemented and delivers a non-null value for a column</li> <li>the column header control's 'text' property if no caption property is available</li> <li>the column header control's 'title' property if neither 'text' nor 'caption' property are available</li> <li>the column id is displayed as last fallback, if none of the above is at hand. In that case, a warning is logged. </li></ul>
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">optional id for the new control; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
				/// <param name="mSettings">optional map/JSON-object with initial settings for the new component instance</param>
				public extern TablePersoDialog(string sId, sap.m.TablePersoDialog.Settings mSettings);

				/// <summary>
				/// The TablePersoDialog can be used to display and allow modification of personalization settings relating to a Table. It displays the columns of the table that it refers to by using <ul><li>The result of calling sap.m.TablePersoProvider's 'getCaption' callback if it is implemented and delivers a non-null value for a column</li> <li>the column header control's 'text' property if no caption property is available</li> <li>the column header control's 'title' property if neither 'text' nor 'caption' property are available</li> <li>the column id is displayed as last fallback, if none of the above is at hand. In that case, a warning is logged. </li></ul>
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">optional id for the new control; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
				public extern TablePersoDialog(string sId);

				/// <summary>
				/// The TablePersoDialog can be used to display and allow modification of personalization settings relating to a Table. It displays the columns of the table that it refers to by using <ul><li>The result of calling sap.m.TablePersoProvider's 'getCaption' callback if it is implemented and delivers a non-null value for a column</li> <li>the column header control's 'text' property if no caption property is available</li> <li>the column header control's 'title' property if neither 'text' nor 'caption' property are available</li> <li>the column id is displayed as last fallback, if none of the above is at hand. In that case, a warning is logged. </li></ul>
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TablePersoDialog();

				/// <summary>
				/// The TablePersoDialog can be used to display and allow modification of personalization settings relating to a Table. It displays the columns of the table that it refers to by using <ul><li>The result of calling sap.m.TablePersoProvider's 'getCaption' callback if it is implemented and delivers a non-null value for a column</li> <li>the column header control's 'text' property if no caption property is available</li> <li>the column header control's 'title' property if neither 'text' nor 'caption' property are available</li> <li>the column id is displayed as last fallback, if none of the above is at hand. In that case, a warning is logged. </li></ul>
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">optional map/JSON-object with initial settings for the new component instance</param>
				public extern TablePersoDialog(sap.m.TablePersoDialog.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property contentWidth

				/// <summary>
				/// Gets current value of property {@link #getContentWidth contentWidth}.
				/// </summary>
				/// <returns>Value of property <code>contentWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentWidth();

				/// <summary>
				/// Sets a new value for property {@link #getContentWidth contentWidth}.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentWidth">New value for property <code>contentWidth</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog setContentWidth(sap.ui.core.CSSSize sContentWidth);

				#endregion

				#region Methods for Property contentHeight

				/// <summary>
				/// Gets current value of property {@link #getContentHeight contentHeight}.
				/// </summary>
				/// <returns>Value of property <code>contentHeight</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentHeight();

				/// <summary>
				/// Sets a new value for property {@link #getContentHeight contentHeight}.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentHeight">New value for property <code>contentHeight</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog setContentHeight(sap.ui.core.CSSSize sContentHeight);

				#endregion

				#region Methods for Property persoMap

				/// <summary>
				/// Gets current value of property {@link #getPersoMap persoMap}.
				/// </summary>
				/// <returns>Value of property <code>persoMap</code></returns>
				public extern virtual object getPersoMap();

				/// <summary>
				/// Sets a new value for property {@link #getPersoMap persoMap}.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oPersoMap">New value for property <code>persoMap</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog setPersoMap(object oPersoMap);

				#endregion

				#region Methods for Property columnInfoCallback

				/// <summary>
				/// Gets current value of property {@link #getColumnInfoCallback columnInfoCallback}.
				/// </summary>
				/// <returns>Value of property <code>columnInfoCallback</code></returns>
				public extern virtual object getColumnInfoCallback();

				/// <summary>
				/// Sets a new value for property {@link #getColumnInfoCallback columnInfoCallback}.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oColumnInfoCallback">New value for property <code>columnInfoCallback</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog setColumnInfoCallback(object oColumnInfoCallback);

				#endregion

				#region Methods for Property initialColumnState

				/// <summary>
				/// Gets current value of property {@link #getInitialColumnState initialColumnState}.
				/// </summary>
				/// <returns>Value of property <code>initialColumnState</code></returns>
				public extern virtual object getInitialColumnState();

				/// <summary>
				/// Sets a new value for property {@link #getInitialColumnState initialColumnState}.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oInitialColumnState">New value for property <code>initialColumnState</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog setInitialColumnState(object oInitialColumnState);

				#endregion

				#region Methods for Property hasGrouping

				/// <summary>
				/// Gets current value of property {@link #getHasGrouping hasGrouping}.
				/// </summary>
				/// <returns>Value of property <code>hasGrouping</code></returns>
				public extern virtual bool getHasGrouping();

				/// <summary>
				/// Setter to turn on/ switch off TablePersoDialog's grouping mode.
				/// </summary>
				/// <param name="bHasGrouping">groping mode on or off.</param>
				/// <returns>the TablePersoDialog instance.</returns>
				public extern virtual sap.m.TablePersoDialog setHasGrouping(bool bHasGrouping);

				#endregion

				#region Methods for Property showSelectAll

				/// <summary>
				/// Gets current value of property {@link #getShowSelectAll showSelectAll}.
				/// </summary>
				/// <returns>Value of property <code>showSelectAll</code></returns>
				public extern virtual bool getShowSelectAll();

				/// <summary>
				/// Setter to show/hide TablePersoDialog's 'selectAll' checkbox.
				/// </summary>
				/// <param name="bShowSelectAll">selectAll checkbox visible or not.</param>
				/// <returns>the TablePersoDialog instance.</returns>
				public extern virtual sap.m.TablePersoDialog setShowSelectAll(bool bShowSelectAll);

				#endregion

				#region Methods for Property showResetAll

				/// <summary>
				/// Gets current value of property {@link #getShowResetAll showResetAll}.
				/// </summary>
				/// <returns>Value of property <code>showResetAll</code></returns>
				public extern virtual bool getShowResetAll();

				/// <summary>
				/// Setter to show/hide TablePersoDialog's 'Undo Personalization' button.
				/// </summary>
				/// <param name="bShowResetAll">'undo Personalization' button visible or not.</param>
				/// <returns>the TablePersoDialog instance.</returns>
				public extern virtual sap.m.TablePersoDialog setShowResetAll(bool bShowResetAll);

				#endregion

				#region Methods for Aggregation persoService

				/// <summary>
				/// Gets content of aggregation {@link #getPersoService persoService}.
				/// 
				/// Refers to the service for reading and writing the personalization.
				/// </summary>
				/// <returns></returns>
				[Obsolete("Deprecated since 1.30.1. This aggregate is no longer used. It collided with the TablePersoController's persoService reference")]
				public extern virtual object getPersoService();

				/// <summary>
				/// Destroys the persoService in the aggregation {@link #getPersoService persoService}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.30.1. This aggregate is no longer used. It collided with the TablePersoController's persoService reference")]
				public extern virtual sap.m.TablePersoDialog destroyPersoService();

				/// <summary>
				/// Sets the aggregated {@link #getPersoService persoService}.
				/// </summary>
				/// <param name="oPersoService">The persoService to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.30.1. This aggregate is no longer used. It collided with the TablePersoController's persoService reference")]
				public extern virtual sap.m.TablePersoDialog setPersoService(object oPersoService);

				#endregion

				#region Methods for Association persoDialogFor

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getPersoDialogFor persoDialogFor}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getPersoDialogFor();

				/// <summary>
				/// Sets the associated {@link #getPersoDialogFor persoDialogFor}.
				/// </summary>
				/// <param name="oPersoDialogFor">ID of an element which becomes the new target of this persoDialogFor association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog setPersoDialogFor(Union<sap.ui.core.ID, sap.m.Table> oPersoDialogFor);

				#endregion

				#region Methods for Event confirm

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoDialog</code> itself.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TablePersoDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog attachConfirm(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoDialog</code> itself.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog attachConfirm(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoDialog</code> itself.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog attachConfirm(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:confirm confirm} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoDialog</code> itself.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TablePersoDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog attachConfirm(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:confirm confirm} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog detachConfirm(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog fireConfirm(object mParameters);

				/// <summary>
				/// Fires event {@link #event:confirm confirm} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog fireConfirm();

				#endregion

				#region Methods for Event cancel

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoDialog</code> itself.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TablePersoDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoDialog</code> itself.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog attachCancel(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoDialog</code> itself.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog attachCancel(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:cancel cancel} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoDialog</code> itself.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TablePersoDialog</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog attachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:cancel cancel} event of this <code>sap.m.TablePersoDialog</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog detachCancel(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog fireCancel(object mParameters);

				/// <summary>
				/// Fires event {@link #event:cancel cancel} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoDialog fireCancel();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.TablePersoDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TablePersoDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TablePersoDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.TablePersoDialog.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Initializes the TablePersoDialog instance after creation.
				/// </summary>
				public extern virtual void init();

				/// <summary>
				/// Sets the content of the dialog, being list items representing the associated table's column settings, and opens the dialog
				/// </summary>
				public extern virtual void open();

				/// <summary>
				/// Returns the personalizations made. Currently supports a 'columns' property which holds an array of settings, one element per column in the associated table. The element contains column-specific information as follows: id: column id; order: new order; text: the column's header text that was displayed in the dialog; visible: visibility (true or false).
				/// </summary>
				/// <returns>the personalization data</returns>
				public extern virtual object retrievePersonalizations();

				#endregion

				#endregion

			}
		}
	}
}
