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
			public static partial class commons
			{
				/// <summary>
				/// Instantiated by the "MessageBar" Control if the user requests to generate the corresponding "MessageList".
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.MessageList")]
				[Obsolete("Deprecated since 1.4.0. A new messaging concept will be created in future. Therefore this control might be removed in one of the next versions.")]
				public partial class MessageList : sap.ui.core.Control
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
						/// Specifies whether or not the MessageList is visible. Invisible controls are not rendered.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

						/// <summary>
						/// ID of the anchor under which the MessageList will render.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> anchorId;

						/// <summary>
						/// Maximum number of messages being display in the List before a scrollbar appears. Value '0' means no limit.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxListed;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new MessageList.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MessageList(string sId, sap.ui.commons.MessageList.Settings mSettings);

					/// <summary>
					/// Constructor for a new MessageList.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern MessageList(string sId);

					/// <summary>
					/// Constructor for a new MessageList.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern MessageList();

					/// <summary>
					/// Constructor for a new MessageList.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MessageList(sap.ui.commons.MessageList.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// Specifies whether or not the MessageList is visible. Invisible controls are not rendered.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern override bool getVisible();

					/// <summary>
					/// Setter for property <code>visible</code>.
					/// 
					/// Default value is <code>true</code>
					/// 
					/// The default implementation of function "setVisible()" is overwritten in order to invoke the open() and close() of the MessageList Popup.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageList setVisible(bool bVisible);

					#endregion

					#region Methods for Property anchorId

					/// <summary>
					/// Gets current value of property {@link #getAnchorId anchorId}.
					/// 
					/// ID of the anchor under which the MessageList will render.
					/// </summary>
					/// <returns>Value of property <code>anchorId</code></returns>
					public extern virtual string getAnchorId();

					/// <summary>
					/// Sets a new value for property {@link #getAnchorId anchorId}.
					/// 
					/// ID of the anchor under which the MessageList will render.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sAnchorId">New value for property <code>anchorId</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageList setAnchorId(string sAnchorId);

					#endregion

					#region Methods for Property maxListed

					/// <summary>
					/// Gets current value of property {@link #getMaxListed maxListed}.
					/// 
					/// Maximum number of messages being display in the List before a scrollbar appears. Value '0' means no limit.
					/// 
					/// Default value is <code>7</code>.
					/// </summary>
					/// <returns>Value of property <code>maxListed</code></returns>
					public extern virtual string getMaxListed();

					/// <summary>
					/// Sets a new value for property {@link #getMaxListed maxListed}.
					/// 
					/// Maximum number of messages being display in the List before a scrollbar appears. Value '0' means no limit.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>7</code>.
					/// </summary>
					/// <param name="sMaxListed">New value for property <code>maxListed</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageList setMaxListed(string sMaxListed);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MessageList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MessageList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MessageList with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.MessageList.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Sets the list of Messages to be displayed and re-renders this Control if it is visible.
					/// </summary>
					/// <param name="aMessages">Message list.</param>
					public extern virtual void setMessages(sap.ui.commons.Message[] aMessages);

					#endregion

					#endregion

				}
			}
		}
	}
}
