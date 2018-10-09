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
			/// The ConditionPanel Control will be used to implement the Sorting, Filtering and Grouping panel of the new Personalization dialog.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.P13nConditionPanel")]
			public partial class P13nConditionPanel : sap.ui.core.Control
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
					/// defines the max number of conditions on the ConditionPanel
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxConditions;

					/// <summary>
					/// exclude options for filter
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> exclude;

					/// <summary>
					/// defines if the mediaQuery or a ContainerResize will be used for layout update. When the <code>P13nConditionPanel</code> is used on a dialog the property should be set to <code>true</code>!
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> containerQuery;

					/// <summary>
					/// adds initial a new empty condition row
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> autoAddNewRow;

					/// <summary>
					/// makes the remove icon on the first condition row disabled when only one condition exist.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> disableFirstRemoveIcon;

					/// <summary>
					/// makes the Add icon visible on each condition row. If is set to false the Add is only visible at the end and you can only append a new condition.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> alwaysShowAddIcon;

					/// <summary>
					/// new added condition use the settings from the previous condition as default.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> usePrevConditionSetting;

					/// <summary>
					/// KeyField value can only be selected once. When you set the property to <code>true</code> the ConditionPanel will automatically offers on the KeyField drop down only the keyFields which are not used. The default behavior is that in each keyField dropdown all keyfields are listed.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> autoReduceKeyFieldItems;

					/// <summary>
					/// can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or "Phone" you can set a fixed layout.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> layoutMode;

					/// <summary>
					/// show additional labels in the condition
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showLabel;

					/// <summary>
					/// This represents the displayFormat of the condition Values. With the value "UpperCase" the entered value of the condition will be converted to upperCase.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayFormat;

					/// <summary>
					/// Calls the validation listener tbd...
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> validationExecutor;

					/// <summary>
					/// Workaround for updating the binding
					/// </summary>
					public sap.ui.@base.EventDelegate dataChange;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new P13nConditionPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nConditionPanel(string sId, sap.m.P13nConditionPanel.Settings mSettings);

				/// <summary>
				/// Constructor for a new P13nConditionPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern P13nConditionPanel(string sId);

				/// <summary>
				/// Constructor for a new P13nConditionPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern P13nConditionPanel();

				/// <summary>
				/// Constructor for a new P13nConditionPanel.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern P13nConditionPanel(sap.m.P13nConditionPanel.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property maxConditions

				/// <summary>
				/// Gets current value of property {@link #getMaxConditions maxConditions}.
				/// 
				/// defines the max number of conditions on the ConditionPanel
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <returns>Value of property <code>maxConditions</code></returns>
				public extern virtual string getMaxConditions();

				/// <summary>
				/// Sets a new value for property {@link #getMaxConditions maxConditions}.
				/// 
				/// defines the max number of conditions on the ConditionPanel
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>-1</code>.
				/// </summary>
				/// <param name="sMaxConditions">New value for property <code>maxConditions</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel setMaxConditions(string sMaxConditions);

				#endregion

				#region Methods for Property exclude

				/// <summary>
				/// Gets current value of property {@link #getExclude exclude}.
				/// 
				/// exclude options for filter
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>exclude</code></returns>
				public extern virtual bool getExclude();

				/// <summary>
				/// Sets a new value for property {@link #getExclude exclude}.
				/// 
				/// exclude options for filter
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bExclude">New value for property <code>exclude</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel setExclude(bool bExclude);

				#endregion

				#region Methods for Property containerQuery

				/// <summary>
				/// Gets current value of property {@link #getContainerQuery containerQuery}.
				/// 
				/// defines if the mediaQuery or a ContainerResize will be used for layout update. When the <code>P13nConditionPanel</code> is used on a dialog the property should be set to <code>true</code>!
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>containerQuery</code></returns>
				public extern virtual bool getContainerQuery();

				#endregion

				#region Methods for Property autoAddNewRow

				/// <summary>
				/// Gets current value of property {@link #getAutoAddNewRow autoAddNewRow}.
				/// 
				/// adds initial a new empty condition row
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>autoAddNewRow</code></returns>
				public extern virtual bool getAutoAddNewRow();

				/// <summary>
				/// Sets a new value for property {@link #getAutoAddNewRow autoAddNewRow}.
				/// 
				/// adds initial a new empty condition row
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bAutoAddNewRow">New value for property <code>autoAddNewRow</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel setAutoAddNewRow(bool bAutoAddNewRow);

				#endregion

				#region Methods for Property disableFirstRemoveIcon

				/// <summary>
				/// Gets current value of property {@link #getDisableFirstRemoveIcon disableFirstRemoveIcon}.
				/// 
				/// makes the remove icon on the first condition row disabled when only one condition exist.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>disableFirstRemoveIcon</code></returns>
				public extern virtual bool getDisableFirstRemoveIcon();

				/// <summary>
				/// Sets a new value for property {@link #getDisableFirstRemoveIcon disableFirstRemoveIcon}.
				/// 
				/// makes the remove icon on the first condition row disabled when only one condition exist.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bDisableFirstRemoveIcon">New value for property <code>disableFirstRemoveIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel setDisableFirstRemoveIcon(bool bDisableFirstRemoveIcon);

				#endregion

				#region Methods for Property alwaysShowAddIcon

				/// <summary>
				/// Gets current value of property {@link #getAlwaysShowAddIcon alwaysShowAddIcon}.
				/// 
				/// makes the Add icon visible on each condition row. If is set to false the Add is only visible at the end and you can only append a new condition.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>alwaysShowAddIcon</code></returns>
				public extern virtual bool getAlwaysShowAddIcon();

				#endregion

				#region Methods for Property usePrevConditionSetting

				/// <summary>
				/// Gets current value of property {@link #getUsePrevConditionSetting usePrevConditionSetting}.
				/// 
				/// new added condition use the settings from the previous condition as default.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>usePrevConditionSetting</code></returns>
				public extern virtual bool getUsePrevConditionSetting();

				/// <summary>
				/// Sets a new value for property {@link #getUsePrevConditionSetting usePrevConditionSetting}.
				/// 
				/// new added condition use the settings from the previous condition as default.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bUsePrevConditionSetting">New value for property <code>usePrevConditionSetting</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel setUsePrevConditionSetting(bool bUsePrevConditionSetting);

				#endregion

				#region Methods for Property autoReduceKeyFieldItems

				/// <summary>
				/// Gets current value of property {@link #getAutoReduceKeyFieldItems autoReduceKeyFieldItems}.
				/// 
				/// KeyField value can only be selected once. When you set the property to <code>true</code> the ConditionPanel will automatically offers on the KeyField drop down only the keyFields which are not used. The default behavior is that in each keyField dropdown all keyfields are listed.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>autoReduceKeyFieldItems</code></returns>
				public extern virtual bool getAutoReduceKeyFieldItems();

				/// <summary>
				/// Sets a new value for property {@link #getAutoReduceKeyFieldItems autoReduceKeyFieldItems}.
				/// 
				/// KeyField value can only be selected once. When you set the property to <code>true</code> the ConditionPanel will automatically offers on the KeyField drop down only the keyFields which are not used. The default behavior is that in each keyField dropdown all keyfields are listed.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bAutoReduceKeyFieldItems">New value for property <code>autoReduceKeyFieldItems</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel setAutoReduceKeyFieldItems(bool bAutoReduceKeyFieldItems);

				#endregion

				#region Methods for Property layoutMode

				/// <summary>
				/// Gets current value of property {@link #getLayoutMode layoutMode}.
				/// 
				/// can be used to control the layout behavior. Default is "" which will automatically change the layout. With "Desktop", "Table" or "Phone" you can set a fixed layout.
				/// </summary>
				/// <returns>Value of property <code>layoutMode</code></returns>
				public extern virtual string getLayoutMode();

				#endregion

				#region Methods for Property showLabel

				/// <summary>
				/// Gets current value of property {@link #getShowLabel showLabel}.
				/// 
				/// show additional labels in the condition
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>showLabel</code></returns>
				public extern virtual bool getShowLabel();

				/// <summary>
				/// Sets a new value for property {@link #getShowLabel showLabel}.
				/// 
				/// show additional labels in the condition
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bShowLabel">New value for property <code>showLabel</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel setShowLabel(bool bShowLabel);

				#endregion

				#region Methods for Property displayFormat

				/// <summary>
				/// Gets current value of property {@link #getDisplayFormat displayFormat}.
				/// 
				/// This represents the displayFormat of the condition Values. With the value "UpperCase" the entered value of the condition will be converted to upperCase.
				/// </summary>
				/// <returns>Value of property <code>displayFormat</code></returns>
				public extern virtual string getDisplayFormat();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayFormat displayFormat}.
				/// 
				/// This represents the displayFormat of the condition Values. With the value "UpperCase" the entered value of the condition will be converted to upperCase.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDisplayFormat">New value for property <code>displayFormat</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel setDisplayFormat(string sDisplayFormat);

				#endregion

				#region Methods for Property validationExecutor

				/// <summary>
				/// Gets current value of property {@link #getValidationExecutor validationExecutor}.
				/// 
				/// Calls the validation listener tbd...
				/// </summary>
				/// <returns>Value of property <code>validationExecutor</code></returns>
				public extern virtual object getValidationExecutor();

				/// <summary>
				/// Sets a new value for property {@link #getValidationExecutor validationExecutor}.
				/// 
				/// Calls the validation listener tbd...
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oValidationExecutor">New value for property <code>validationExecutor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel setValidationExecutor(object oValidationExecutor);

				#endregion

				#region Methods for Aggregation content

				#endregion

				#region Methods for Event dataChange

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:dataChange dataChange} event of this <code>sap.m.P13nConditionPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nConditionPanel</code> itself.
				/// 
				/// Workaround for updating the binding
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nConditionPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel attachDataChange(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:dataChange dataChange} event of this <code>sap.m.P13nConditionPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nConditionPanel</code> itself.
				/// 
				/// Workaround for updating the binding
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel attachDataChange(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:dataChange dataChange} event of this <code>sap.m.P13nConditionPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nConditionPanel</code> itself.
				/// 
				/// Workaround for updating the binding
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel attachDataChange(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:dataChange dataChange} event of this <code>sap.m.P13nConditionPanel</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.P13nConditionPanel</code> itself.
				/// 
				/// Workaround for updating the binding
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.P13nConditionPanel</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel attachDataChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:dataChange dataChange} event of this <code>sap.m.P13nConditionPanel</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel detachDataChange(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:dataChange dataChange} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel fireDataChange(object mParameters);

				/// <summary>
				/// Fires event {@link #event:dataChange dataChange} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.P13nConditionPanel fireDataChange();

				#endregion

				#region Other methods

				/// <summary>
				/// add a single condition.
				/// </summary>
				/// <param name="oCondition">the new condition of type <code>{ "key": "007", "operation": sap.m.P13nConditionOperation.Ascending, "keyField": "keyFieldKey", "value1": "", "value2": ""};</code></param>
				public extern virtual void addCondition(object oCondition);

				/// <summary>
				/// add a single KeyField
				/// </summary>
				/// <param name="oKeyField">{key: "CompanyCode", text: "ID"}</param>
				public extern virtual void addKeyField(object oKeyField);

				/// <summary>
				/// add a single operation
				/// </summary>
				/// <param name="oOperation"></param>
				/// <param name="sType">defines the type for which this operations will be used.</param>
				public extern virtual void addOperation(sap.m.P13nConditionOperation oOperation, string sType);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nConditionPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nConditionPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.P13nConditionPanel with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// returns array of all defined conditions.
				/// </summary>
				/// <returns>array of Conditions</returns>
				public extern virtual object[] getConditions();

				/// <summary>
				/// getter for KeyFields array
				/// </summary>
				/// <returns>array of KeyFields <code>[{key: "CompanyCode", text: "ID"}, {key:"CompanyName", text : "Name"}]</code></returns>
				public extern virtual object[] getKeyFields();

				/// <summary>
				/// Returns a metadata object for class sap.m.P13nConditionPanel.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// returns the default array of operations
				/// </summary>
				/// <param name="sType">defines the type for which the operations should be returned.</param>
				/// <returns>array of operations</returns>
				public extern virtual sap.m.P13nConditionOperation[] getOperations(string sType);

				/// <summary>
				/// insert a single condition.
				/// </summary>
				/// <param name="oCondition">the new condition of type <code>{ "key": "007", "operation": sap.m.P13nConditionOperation.Ascending, "keyField": "keyFieldKey", "value1": "", "value2": ""};</code></param>
				/// <param name="index">of the new condition</param>
				public extern virtual void insertCondition(object oCondition, int index);

				/// <summary>
				/// remove all conditions.
				/// </summary>
				public extern virtual void removeAllConditions();

				/// <summary>
				/// removes all KeyFields
				/// </summary>
				public extern virtual void removeAllKeyFields();

				/// <summary>
				/// remove all operations
				/// </summary>
				/// <param name="sType">defines the type for which all operations should be removed</param>
				public extern virtual void removeAllOperations(string sType);

				/// <summary>
				/// remove a single condition.
				/// </summary>
				/// <param name="vCondition">is the condition which should be removed. can be either a string with the key of the condition of the condition object itself.</param>
				public extern virtual void removeCondition(object vCondition);

				/// <summary>
				/// removes all invalid conditions.
				/// </summary>
				public extern virtual void removeInvalidConditions();

				/// <summary>
				/// removes all errors/warning states from the value1/2 fields of all conditions.
				/// </summary>
				public extern virtual void removeValidationErrors();

				/// <summary>
				/// This method must be used to assign a list of conditions.
				/// </summary>
				/// <param name="aConditions">array of Conditions.</param>
				public extern virtual void setConditions(object[] aConditions);

				/// <summary>
				/// This method allows you to specify the KeyFields for the conditions. You can set an array of object with Key and Text properties to define the keyfields.
				/// </summary>
				/// <param name="aKeyFields">array of KeyFields <code>[{key: "CompanyCode", text: "ID"}, {key:"CompanyName", text : "Name"}]</code></param>
				public extern virtual void setKeyFields(object[] aKeyFields);

				/// <summary>
				/// setter for the supported operations which we show per condition row. This array of "default" operations will only be used when we do not have on the keyfield itself some specific operations and a keyfield is of not of type date or numeric.
				/// </summary>
				/// <param name="aOperations">array of operations <code>[sap.m.P13nConditionOperation.BT, sap.m.P13nConditionOperation.EQ]</code></param>
				/// <param name="sType">defines the type for which this operations will be used. is <code>sType</code> is not defined the operations will be used as default operations.</param>
				public extern virtual void setOperations(sap.m.P13nConditionOperation[] aOperations, string sType);

				#endregion

				#endregion

			}
		}
	}
}
