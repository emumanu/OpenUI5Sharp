using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// Table Personalization Controller
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class TablePersoController : sap.ui.@base.ManagedObject
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.@base.ManagedObject.Settings
				{
					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> contentWidth;

					public Union<sap.ui.core.CSSSize, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> contentHeight;

					/// <summary>
					/// Available options for the text direction are LTR and RTL. By default the control inherits the text direction from its parent control.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> componentName;

					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> hasGrouping;

					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showSelectAll;

					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showResetAll;

					public Union<object, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> persoService;

					public Union<sap.m.Table, sap.ui.core.ID, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> table;

					/// <summary>
					/// Also several tables may be personalized at once given they have same columns.
					/// </summary>
					public Union<sap.m.Table, sap.ui.core.ID[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> tables;

					public sap.ui.@base.EventDelegate personalizationsDone;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// The TablePersoController can be used to connect a table that you want to provide a personalization dialog for, with a persistence service such as one provided by the unified shell.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">optional id for the new control; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
				/// <param name="mSettings">optional map/JSON-object with initial settings for the new component instance</param>
				public extern TablePersoController(string sId, sap.m.TablePersoController.Settings mSettings);

				/// <summary>
				/// The TablePersoController can be used to connect a table that you want to provide a personalization dialog for, with a persistence service such as one provided by the unified shell.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">optional id for the new control; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
				public extern TablePersoController(string sId);

				/// <summary>
				/// The TablePersoController can be used to connect a table that you want to provide a personalization dialog for, with a persistence service such as one provided by the unified shell.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern TablePersoController();

				/// <summary>
				/// The TablePersoController can be used to connect a table that you want to provide a personalization dialog for, with a persistence service such as one provided by the unified shell.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">optional map/JSON-object with initial settings for the new component instance</param>
				public extern TablePersoController(sap.m.TablePersoController.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property contentWidth

				/// <summary>
				/// Gets current value of property {@link #getContentWidth contentWidth}.
				/// </summary>
				/// <returns>Value of property <code>contentWidth</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentWidth();

				/// <summary>
				/// Reflector for the controller's 'contentWidth' property.
				/// </summary>
				/// <param name="sWidth">the new width of the tablePersoDialog</param>
				/// <returns>the TablePersoController instance.</returns>
				public extern virtual sap.m.TablePersoController setContentWidth(sap.ui.core.CSSSize sWidth);

				#endregion

				#region Methods for Property contentHeight

				/// <summary>
				/// Gets current value of property {@link #getContentHeight contentHeight}.
				/// 
				/// Default value is <code>20rem</code>.
				/// </summary>
				/// <returns>Value of property <code>contentHeight</code></returns>
				public extern virtual sap.ui.core.CSSSize getContentHeight();

				/// <summary>
				/// Reflector for the controller's 'contentHeight' property.
				/// </summary>
				/// <param name="sHeight">the new height of the TablePersoDialog.</param>
				/// <returns>the TablePersoController instance.</returns>
				public extern virtual sap.m.TablePersoController setContentHeight(sap.ui.core.CSSSize sHeight);

				#endregion

				#region Methods for Property componentName

				/// <summary>
				/// Gets current value of property {@link #getComponentName componentName}.
				/// 
				/// Available options for the text direction are LTR and RTL. By default the control inherits the text direction from its parent control.
				/// </summary>
				/// <returns>Value of property <code>componentName</code></returns>
				public extern virtual string getComponentName();

				/// <summary>
				/// Using this method, the first part of tablePerso persistence ids can be provided, in case the table's app does not provide that part itself.
				/// 
				/// If a component name is set using this method, it will be used, regardless of whether the table's app has a different component name or not.
				/// </summary>
				/// <param name="sCompName">the new component name.</param>
				/// <returns>the TablePersoController instance.</returns>
				public extern virtual sap.m.TablePersoController setComponentName(string sCompName);

				#endregion

				#region Methods for Property hasGrouping

				/// <summary>
				/// Gets current value of property {@link #getHasGrouping hasGrouping}.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>hasGrouping</code></returns>
				public extern virtual bool getHasGrouping();

				/// <summary>
				/// Reflector for the controller's 'hasGrouping' property.
				/// </summary>
				/// <param name="bHasGrouping">is the tablePersoDialog displayed in grouping mode or not.</param>
				/// <returns>the TablePersoController instance.</returns>
				public extern virtual sap.m.TablePersoController setHasGrouping(bool bHasGrouping);

				#endregion

				#region Methods for Property showSelectAll

				/// <summary>
				/// Gets current value of property {@link #getShowSelectAll showSelectAll}.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showSelectAll</code></returns>
				public extern virtual bool getShowSelectAll();

				/// <summary>
				/// Reflector for the controller's 'showSelectAll' property.
				/// </summary>
				/// <param name="bShowSelectAll">is the tablePersoDialog's 'Display All' checkbox displayed or not.</param>
				/// <returns>the TablePersoController instance.</returns>
				public extern virtual sap.m.TablePersoController setShowSelectAll(bool bShowSelectAll);

				#endregion

				#region Methods for Property showResetAll

				/// <summary>
				/// Gets current value of property {@link #getShowResetAll showResetAll}.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showResetAll</code></returns>
				public extern virtual bool getShowResetAll();

				/// <summary>
				/// Reflector for the controller's 'showResetAll' property.
				/// </summary>
				/// <param name="bShowResetAll">is the tablePersoDialog's 'UndoPersonalization' button displayed or not.</param>
				/// <returns>the TablePersoController instance.</returns>
				public extern virtual sap.m.TablePersoController setShowResetAll(bool bShowResetAll);

				#endregion

				#region Methods for Aggregation _tablePersoDialog

				#endregion

				#region Methods for Aggregation persoService

				/// <summary>
				/// Gets content of aggregation {@link #getPersoService persoService}.
				/// </summary>
				/// <returns></returns>
				public extern virtual object getPersoService();

				/// <summary>
				/// Destroys the persoService in the aggregation {@link #getPersoService persoService}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController destroyPersoService();

				/// <summary>
				/// Sets the aggregated {@link #getPersoService persoService}.
				/// </summary>
				/// <param name="oPersoService">The persoService to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController setPersoService(object oPersoService);

				#endregion

				#region Methods for Association table

				/// <summary>
				/// ID of the element which is the current target of the association {@link #getTable table}, or <code>null</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID getTable();

				/// <summary>
				/// Sets the associated {@link #getTable table}.
				/// </summary>
				/// <param name="oTable">ID of an element which becomes the new target of this table association; alternatively, an element instance may be given</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController setTable(Union<sap.ui.core.ID, sap.m.Table> oTable);

				#endregion

				#region Methods for Association tables

				/// <summary>
				/// Returns array of IDs of the elements which are the current targets of the association {@link #getTables tables}.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.ID[] getTables();

				/// <summary>
				/// Adds some table into the association {@link #getTables tables}.
				/// </summary>
				/// <param name="vTable">The tables to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController addTable(Union<sap.ui.core.ID, sap.m.Table> vTable);

				/// <summary>
				/// Removes an table from the association named {@link #getTables tables}.
				/// </summary>
				/// <param name="vTable">The table to be removed or its index or ID</param>
				/// <returns>The removed table or <code>null</code></returns>
				public extern virtual sap.ui.core.ID removeTable(Union<int, sap.ui.core.ID, sap.m.Table> vTable);

				/// <summary>
				/// Removes all the controls in the association named {@link #getTables tables}.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.ID[] removeAllTables();

				#endregion

				#region Methods for Event personalizationsDone

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:personalizationsDone personalizationsDone} event of this <code>sap.m.TablePersoController</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoController</code> itself.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TablePersoController</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController attachPersonalizationsDone(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:personalizationsDone personalizationsDone} event of this <code>sap.m.TablePersoController</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoController</code> itself.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController attachPersonalizationsDone(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:personalizationsDone personalizationsDone} event of this <code>sap.m.TablePersoController</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoController</code> itself.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController attachPersonalizationsDone(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:personalizationsDone personalizationsDone} event of this <code>sap.m.TablePersoController</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.TablePersoController</code> itself.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.TablePersoController</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController attachPersonalizationsDone(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:personalizationsDone personalizationsDone} event of this <code>sap.m.TablePersoController</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController detachPersonalizationsDone(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:personalizationsDone personalizationsDone} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController firePersonalizationsDone(object mParameters);

				/// <summary>
				/// Fires event {@link #event:personalizationsDone personalizationsDone} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.TablePersoController firePersonalizationsDone();

				#endregion

				#region Other methods

				/// <summary>
				/// Activates the controller, i.e. tries to retrieve existing persisted personalizations, creates a TablePersoDialog for the associated table and attaches a close handler to apply the personalizations to the table and persist them.
				/// 
				/// This method should be called when the table to be personalized knows its columns. Usually, this is when that table's view has set its model, which is typically done in the corresponding controller's init method. For example <pre><code>
				///  onInit: function () {
				/// 
				/// 		// set explored app's demo model on this sample
				/// 		var oModel = new JSONModel(jQuery.sap.getModulePath("sap.ui.demo.mock", "/products.json"));
				/// 		var oGroupingModel = new JSONModel({ hasGrouping: false});
				/// 		this.getView().setModel(oModel);
				/// 		this.getView().setModel(oGroupingModel, 'Grouping');
				/// 
				/// 		// init and activate controller
				/// 		this._oTPC = new TablePersoController({
				/// 			table: this.getView().byId("productsTable"),
				/// 			//specify the first part of persistence ids e.g. 'demoApp-productsTable-dimensionsCol'
				/// 			componentName: "demoApp",
				/// 			persoService: DemoPersoService,
				/// 		}).activate();
				/// 	}
				/// </code></pre>
				/// </summary>
				/// <returns>the TablePersoController instance.</returns>
				public extern virtual sap.m.TablePersoController activate();

				/// <summary>
				/// Applies the personalizations by getting the existing personalizations and adjusting to the table.
				/// </summary>
				/// <param name="oTable">the table to be personalized.</param>
				public extern virtual void applyPersonalizations(sap.m.Table oTable);

				/// <summary>
				/// Do some clean up: remove event delegates, etc
				/// </summary>
				public extern virtual void exit();

				/// <summary>
				/// Creates a new subclass of class sap.m.TablePersoController with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TablePersoController with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TablePersoController with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.TablePersoController.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Returns a _tablePersoDialog instance if available. It can be NULL if the controller has not been activated yet.
				/// 
				/// This function makes a private aggregate publicly accessable. This is necessary for downward compatibility reasons: in the first versions of the tablePersoProvider developers still worked with the TablePersoDialog directly, which is now not necessary any longer.
				/// </summary>
				/// <returns>the TablePersoDialog instance.</returns>
				public extern virtual sap.m.TablePersoDialog getTablePersoDialog();

				/// <summary>
				/// Initializes the TablePersoController instance after creation.
				/// </summary>
				public extern virtual void init();

				/// <summary>
				/// Opens the TablePersoDialog, stores the personalized settings on close, modifies the table columns, and sends them to the persistence service
				/// </summary>
				public extern virtual void openDialog();

				/// <summary>
				/// Refresh the personalizations: reloads the personalization information from the table perso provider, applies it to the controller's table and updates the controller's table perso dialog.
				/// 
				/// Use case for a 'refresh' call would be that the table which si personalized changed its columns during runtime, after personalization has been activated.
				/// </summary>
				public extern virtual void refresh();

				/// <summary>
				/// Persist the personalizations
				/// </summary>
				public extern virtual void savePersonalizations();

				#endregion

				#endregion

			}
		}
	}
}
