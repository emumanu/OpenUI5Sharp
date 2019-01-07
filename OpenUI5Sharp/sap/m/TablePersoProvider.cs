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
			/// Table Personalization Provider
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.TablePersoProvider")]
			public abstract partial class TablePersoProvider : sap.ui.@base.ManagedObject
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.@base.ManagedObject.Settings
				{
				}

				#endregion

				#region Constructor

				/// <summary>
				/// This is an abstract TablePersoProvider, describing the interface for a real TablePersoProvider.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
				/// </summary>
				/// <param name="sId">ID for the new managed object; generated automatically if no non-empty ID is given <b>Note:</b> this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
				/// <param name="mSettings">Optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
				/// <param name="oScope">Scope object for resolving string based type and formatter references in bindings. When a scope object is given, <code>mSettings</code> cannot be omitted, at least <code>null</code> or an empty object literal must be given.</param>
				public extern TablePersoProvider(string sId, sap.m.TablePersoProvider.Settings mSettings, object oScope);

				/// <summary>
				/// This is an abstract TablePersoProvider, describing the interface for a real TablePersoProvider.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
				/// </summary>
				/// <param name="sId">ID for the new managed object; generated automatically if no non-empty ID is given <b>Note:</b> this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
				/// <param name="mSettings">Optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
				public extern TablePersoProvider(string sId, sap.m.TablePersoProvider.Settings mSettings);

				/// <summary>
				/// This is an abstract TablePersoProvider, describing the interface for a real TablePersoProvider.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
				/// </summary>
				/// <param name="sId">ID for the new managed object; generated automatically if no non-empty ID is given <b>Note:</b> this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
				public extern TablePersoProvider(string sId);

				/// <summary>
				/// This is an abstract TablePersoProvider, describing the interface for a real TablePersoProvider.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
				/// </summary>
				public extern TablePersoProvider();

				/// <summary>
				/// This is an abstract TablePersoProvider, describing the interface for a real TablePersoProvider.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
				/// </summary>
				/// <param name="mSettings">Optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
				public extern TablePersoProvider(sap.m.TablePersoProvider.Settings mSettings);

				/// <summary>
				/// This is an abstract TablePersoProvider, describing the interface for a real TablePersoProvider.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
				/// </summary>
				/// <param name="mSettings">Optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
				/// <param name="oScope">Scope object for resolving string based type and formatter references in bindings. When a scope object is given, <code>mSettings</code> cannot be omitted, at least <code>null</code> or an empty object literal must be given.</param>
				public extern TablePersoProvider(sap.m.TablePersoProvider.Settings mSettings, object oScope);

				/// <summary>
				/// This is an abstract TablePersoProvider, describing the interface for a real TablePersoProvider.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// 
				/// This class does not have its own settings, but all settings applicable to the base type {@link sap.ui.base.ManagedObject#constructor sap.ui.base.ManagedObject} can be used.
				/// </summary>
				/// <param name="oScope">Scope object for resolving string based type and formatter references in bindings. When a scope object is given, <code>mSettings</code> cannot be omitted, at least <code>null</code> or an empty object literal must be given.</param>
				public extern TablePersoProvider(object oScope);

				#endregion

				#region Methods

				/// <summary>
				/// Removes the personalization bundle This must return a jQuery promise (see http://api.jquery.com/promise/)
				/// </summary>
				/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
				/// <returns></returns>
				public abstract es5.Promise<object> delPersData();

				/// <summary>
				/// Creates a new subclass of class sap.m.TablePersoProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TablePersoProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TablePersoProvider with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.ManagedObject.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Callback function which can be used to determine the title of a given column within the TablePersoDialog. As a default, the column header controls are asked for their 'text' or 'title' property. This works in most cases, for example if the header control is an sap.m.Label (has 'text' property) or an sap.m.ObjectListItem (has 'title' property).
				/// 
				/// If the header control used in a column has neither 'text' nor 'title' property, or if you would like to display a modified column name for a certain column, this callback function can be used.
				/// 
				/// If the callback delivers null for a column (which is the default implementation), the default texts described above are displayed for that column in the TablePersoDialog.
				/// 
				/// In case neither the callback delivers null and neither 'text' nor ' title' property are at hand, the TablePersoDialog will display the column id and a warning message is logged.
				/// </summary>
				/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
				/// <param name="oColumn">column whose caption shall be determined</param>
				/// <returns></returns>
				public abstract object getCaption(sap.m.Column oColumn);

				/// <summary>
				/// Callback function which can be used to determine the group of a given column within the TablePersoDialog. As a default, the columns are not assigned to a group.
				/// 
				/// This information is used to group the columns within the TablePersoDialog if the TablePersoController's 'group' flag is set, otherwise, the groups are ignored.
				/// </summary>
				/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
				/// <param name="oColumn">column whose group shall be determined</param>
				/// <returns></returns>
				public abstract object getGroup(sap.m.Column oColumn);

				/// <summary>
				/// Returns a metadata object for class sap.m.TablePersoProvider.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Retrieves the personalization bundle. This must return a jQuery promise (see http://api.jquery.com/promise/)
				/// </summary>
				/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
				/// <returns></returns>
				public abstract es5.Promise<object> getPersData();

				/// <summary>
				/// Initializes the TablePersoProvider instance after creation.
				/// </summary>
				public extern virtual void init();

				/// <summary>
				/// Resets user’s personalization for a given table so that ‘getPersData’ will deliver its initial state. If no table is specified, all personalizations of the currently logged on user are reset.
				/// 
				/// This must return a jQuery promise (see http://api.jquery.com/promise/)
				/// </summary>
				/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
				/// <returns></returns>
				public abstract es5.Promise<object> resetPersData();

				/// <summary>
				/// Stores the personalization bundle, overwriting any previous bundle completely This must return a jQuery promise (see http://api.jquery.com/promise/)
				/// </summary>
				/// <remarks>This method is abstract, so it should not be called from subclasses as it is not implemented.</remarks>
				/// <param name="oBundle"></param>
				/// <returns></returns>
				public abstract es5.Promise<object> setPersData(object oBundle);

				#endregion

			}
		}
	}
}
