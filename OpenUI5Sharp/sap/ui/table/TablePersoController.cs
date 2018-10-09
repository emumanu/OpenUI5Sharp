using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class table
			{
				/// <summary>
				/// The TablePersoController can be used to connect a table with a persistence service.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.table.TablePersoController")]
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
						/// <summary>
						/// Auto save state
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> autoSave;

						/// <summary>
						/// Personalization Service object. Needs to have the following methods: <ul> <li>getPersData() : <code>jQuery Promise</code> (http://api.jquery.com/promise/)</li> <li>setPersData(oBundle) : <code>jQuery Promise</code> (http://api.jquery.com/promise/)</li> <li>delPersData() : <code>jQuery Promise</code> (http://api.jquery.com/promise/)</li> </ul>
						/// </summary>
						public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> persoService;

						/// <summary>
						/// By defining a custom data key the <code>TablePersoController</code> will try to get the key for saving the perso data from the custom data of the Table and Column instead of creating it by concatenating the ID of the Table and the Column. Basically this will be more stable than using the auto IDs.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> customDataKey;

						/// <summary>
						/// The target table of this controller.
						/// </summary>
						public Union<sap.ui.table.Table, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> table;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new TablePersoController.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TablePersoController(string sId, sap.ui.table.TablePersoController.Settings mSettings);

					/// <summary>
					/// Constructor for a new TablePersoController.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern TablePersoController(string sId);

					/// <summary>
					/// Constructor for a new TablePersoController.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern TablePersoController();

					/// <summary>
					/// Constructor for a new TablePersoController.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TablePersoController(sap.ui.table.TablePersoController.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property autoSave

					/// <summary>
					/// Gets current value of property {@link #getAutoSave autoSave}.
					/// 
					/// Auto save state
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>autoSave</code></returns>
					public extern virtual bool getAutoSave();

					/// <summary>
					/// Sets a new value for property {@link #getAutoSave autoSave}.
					/// 
					/// Auto save state
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bAutoSave">New value for property <code>autoSave</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TablePersoController setAutoSave(bool bAutoSave);

					#endregion

					#region Methods for Property persoService

					/// <summary>
					/// Gets current value of property {@link #getPersoService persoService}.
					/// 
					/// Personalization Service object. Needs to have the following methods: <ul> <li>getPersData() : <code>jQuery Promise</code> (http://api.jquery.com/promise/)</li> <li>setPersData(oBundle) : <code>jQuery Promise</code> (http://api.jquery.com/promise/)</li> <li>delPersData() : <code>jQuery Promise</code> (http://api.jquery.com/promise/)</li> </ul>
					/// </summary>
					/// <returns>Value of property <code>persoService</code></returns>
					public extern virtual object getPersoService();

					/// <summary>
					/// Sets a new value for property {@link #getPersoService persoService}.
					/// 
					/// Personalization Service object. Needs to have the following methods: <ul> <li>getPersData() : <code>jQuery Promise</code> (http://api.jquery.com/promise/)</li> <li>setPersData(oBundle) : <code>jQuery Promise</code> (http://api.jquery.com/promise/)</li> <li>delPersData() : <code>jQuery Promise</code> (http://api.jquery.com/promise/)</li> </ul>
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="oPersoService">New value for property <code>persoService</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TablePersoController setPersoService(object oPersoService);

					#endregion

					#region Methods for Property customDataKey

					/// <summary>
					/// Gets current value of property {@link #getCustomDataKey customDataKey}.
					/// 
					/// By defining a custom data key the <code>TablePersoController</code> will try to get the key for saving the perso data from the custom data of the Table and Column instead of creating it by concatenating the ID of the Table and the Column. Basically this will be more stable than using the auto IDs.
					/// 
					/// Default value is <code>persoKey</code>.
					/// </summary>
					/// <returns>Value of property <code>customDataKey</code></returns>
					public extern virtual string getCustomDataKey();

					/// <summary>
					/// Sets a new value for property {@link #getCustomDataKey customDataKey}.
					/// 
					/// By defining a custom data key the <code>TablePersoController</code> will try to get the key for saving the perso data from the custom data of the Table and Column instead of creating it by concatenating the ID of the Table and the Column. Basically this will be more stable than using the auto IDs.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>persoKey</code>.
					/// </summary>
					/// <param name="sCustomDataKey">New value for property <code>customDataKey</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.table.TablePersoController setCustomDataKey(string sCustomDataKey);

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
					public extern virtual sap.ui.table.TablePersoController setTable(Union<sap.ui.core.ID, sap.ui.table.Table> oTable);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.TablePersoController with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.TablePersoController with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.table.TablePersoController with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.table.TablePersoController.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Opens the personalization dialog for the Table to modify the visibility and the order of the columns.
					/// 
					/// <i>Using this functionality will require to load the sap.m library because the personalization dialog is only available in this library for now.</i>
					/// </summary>
					/// <param name="mSettings"></param>
					public extern virtual void openDialog(object mSettings);

					/// <summary>
					/// Refresh the personalizations (reloads data from service).
					/// </summary>
					/// <returns><code>jQuery Promise</code> which is resolved once the refresh is finished</returns>
					public extern virtual jquery.JQueryPromise<object> refresh();

					/// <summary>
					/// Saves the current personalization state.
					/// </summary>
					/// <returns><code>jQuery Promise</code> which is resolved once the save is finished</returns>
					public extern virtual jquery.JQueryPromise<object> savePersonalizations();

					#endregion

					#endregion

				}
			}
		}
	}
}
