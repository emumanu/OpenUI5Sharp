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
			/// <code>sap.m.GrowingList</code> control is the container for all list items and inherits from sap.m.List control. Everything like the selection, deletion, unread states and inset style are also maintained here. In addition the control provides a loading mechanism to request data from the model and append the list items to the list. The request is started manually by tapping on the trigger at the end of the list.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.GrowingList")]
			[Obsolete("Deprecated since 1.16. Instead use 'List' or 'Table' control with setting 'growing' property to 'true'")]
			public partial class GrowingList : sap.m.List
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.List.Settings
				{
					/// <summary>
					/// Number of items requested from the server. To activate this you should set growing property to "true"
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> threshold;

					/// <summary>
					/// Text which is displayed on the trigger at the end of the list. The default is a translated text ("Load More Data") coming from the messagebundle properties. This property can be used only if growing property is set "true" and scrollToLoad property is set "false".
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> triggerText;

					/// <summary>
					/// If you set this property to true then user needs to scroll end to trigger loading a new page. Default value is false which means user needs to scroll end and then click button to load new page. NOTE: This property can be set true, if growing property is set "true" and if you only have one instance of this control inside the scroll container(e.g Page).
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> scrollToLoad;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new GrowingList.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern GrowingList(string sId, sap.m.GrowingList.Settings mSettings);

				/// <summary>
				/// Constructor for a new GrowingList.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern GrowingList(string sId);

				/// <summary>
				/// Constructor for a new GrowingList.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern GrowingList();

				/// <summary>
				/// Constructor for a new GrowingList.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern GrowingList(sap.m.GrowingList.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property threshold

				/// <summary>
				/// Gets current value of property {@link #getThreshold threshold}.
				/// 
				/// Number of items requested from the server. To activate this you should set growing property to "true"
				/// 
				/// Default value is <code>20</code>.
				/// </summary>
				/// <returns>Value of property <code>threshold</code></returns>
				public extern virtual int getThreshold();

				/// <summary>
				/// Sets a new value for property {@link #getThreshold threshold}.
				/// 
				/// Number of items requested from the server. To activate this you should set growing property to "true"
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>20</code>.
				/// </summary>
				/// <param name="iThreshold">New value for property <code>threshold</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GrowingList setThreshold(int iThreshold);

				#endregion

				#region Methods for Property triggerText

				/// <summary>
				/// Gets current value of property {@link #getTriggerText triggerText}.
				/// 
				/// Text which is displayed on the trigger at the end of the list. The default is a translated text ("Load More Data") coming from the messagebundle properties. This property can be used only if growing property is set "true" and scrollToLoad property is set "false".
				/// </summary>
				/// <returns>Value of property <code>triggerText</code></returns>
				public extern virtual string getTriggerText();

				/// <summary>
				/// Sets a new value for property {@link #getTriggerText triggerText}.
				/// 
				/// Text which is displayed on the trigger at the end of the list. The default is a translated text ("Load More Data") coming from the messagebundle properties. This property can be used only if growing property is set "true" and scrollToLoad property is set "false".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTriggerText">New value for property <code>triggerText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GrowingList setTriggerText(string sTriggerText);

				#endregion

				#region Methods for Property scrollToLoad

				/// <summary>
				/// Gets current value of property {@link #getScrollToLoad scrollToLoad}.
				/// 
				/// If you set this property to true then user needs to scroll end to trigger loading a new page. Default value is false which means user needs to scroll end and then click button to load new page. NOTE: This property can be set true, if growing property is set "true" and if you only have one instance of this control inside the scroll container(e.g Page).
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>scrollToLoad</code></returns>
				public extern virtual bool getScrollToLoad();

				/// <summary>
				/// Sets a new value for property {@link #getScrollToLoad scrollToLoad}.
				/// 
				/// If you set this property to true then user needs to scroll end to trigger loading a new page. Default value is false which means user needs to scroll end and then click button to load new page. NOTE: This property can be set true, if growing property is set "true" and if you only have one instance of this control inside the scroll container(e.g Page).
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bScrollToLoad">New value for property <code>scrollToLoad</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.GrowingList setScrollToLoad(bool bScrollToLoad);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.GrowingList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.List.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.GrowingList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.List.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.GrowingList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.List.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.GrowingList.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
