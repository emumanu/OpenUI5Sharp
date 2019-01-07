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
				/// Creates an instance of a MessageBar Control, for displaying messages.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.MessageBar")]
				[Obsolete("Deprecated since 1.4.0. Instead, use the <code>sap.m.MessagePopover</code> control.")]
				public partial class MessageBar : sap.ui.core.Control
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
						/// Element ID upon which the MessageBar will be initially positioned.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> anchorID;

						/// <summary>
						/// Specifies whether or not the MessageBar is visible. Invisible controls are not rendered.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

						/// <summary>
						/// Maximum number of simultaneous messages being toasted in a row. Value '0' means this dynamic part is switched off.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxToasted;

						/// <summary>
						/// Maximum number of messages being displayed in the List before a scrollbar appears. Value '0' means no limit.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxListed;

						/// <summary>
						/// Type: sap.ui.core.Popup.Dock SnapPoint of MessageBar over anchorId. Note: Use "begin" or "end" for RTL support. Note: "center" is not indicated, as positioning is only set once, either via the css "left" or the "right" attribute. Therefore a MessageBar will only be extended in one direction, as Messages come in.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> anchorSnapPoint;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new MessageBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MessageBar(string sId, sap.ui.commons.MessageBar.Settings mSettings);

					/// <summary>
					/// Constructor for a new MessageBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
					public extern MessageBar(string sId);

					/// <summary>
					/// Constructor for a new MessageBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern MessageBar();

					/// <summary>
					/// Constructor for a new MessageBar.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control</param>
					public extern MessageBar(sap.ui.commons.MessageBar.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property anchorID

					/// <summary>
					/// Gets current value of property {@link #getAnchorID anchorID}.
					/// 
					/// Element ID upon which the MessageBar will be initially positioned.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <returns>Value of property <code>anchorID</code></returns>
					public extern virtual string getAnchorID();

					/// <summary>
					/// Sets a new value for property {@link #getAnchorID anchorID}.
					/// 
					/// Element ID upon which the MessageBar will be initially positioned.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>empty string</code>.
					/// </summary>
					/// <param name="sAnchorID">New value for property <code>anchorID</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageBar setAnchorID(string sAnchorID);

					#endregion

					#region Methods for Property visible

					/// <summary>
					/// Gets current value of property {@link #getVisible visible}.
					/// 
					/// Specifies whether or not the MessageBar is visible. Invisible controls are not rendered.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visible</code></returns>
					public extern override bool getVisible();

					/// <summary>
					/// Setter for property <code>visible</code>.
					/// 
					/// Default value is <code>true</code>
					/// 
					/// The default implementation of function <code>setVisible()</code> is enhanced in order to toggle the <code>visibility:hidden;</code> attribute over the control.
					/// </summary>
					/// <param name="bVisible">New value for property <code>visible</code></param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageBar setVisible(bool bVisible);

					#endregion

					#region Methods for Property maxToasted

					/// <summary>
					/// Gets current value of property {@link #getMaxToasted maxToasted}.
					/// 
					/// Maximum number of simultaneous messages being toasted in a row. Value '0' means this dynamic part is switched off.
					/// 
					/// Default value is <code>3</code>.
					/// </summary>
					/// <returns>Value of property <code>maxToasted</code></returns>
					public extern virtual int getMaxToasted();

					/// <summary>
					/// Sets a new value for property {@link #getMaxToasted maxToasted}.
					/// 
					/// Maximum number of simultaneous messages being toasted in a row. Value '0' means this dynamic part is switched off.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>3</code>.
					/// </summary>
					/// <param name="iMaxToasted">New value for property <code>maxToasted</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageBar setMaxToasted(int iMaxToasted);

					#endregion

					#region Methods for Property maxListed

					/// <summary>
					/// Gets current value of property {@link #getMaxListed maxListed}.
					/// 
					/// Maximum number of messages being displayed in the List before a scrollbar appears. Value '0' means no limit.
					/// 
					/// Default value is <code>7</code>.
					/// </summary>
					/// <returns>Value of property <code>maxListed</code></returns>
					public extern virtual int getMaxListed();

					/// <summary>
					/// Sets a new value for property {@link #getMaxListed maxListed}.
					/// 
					/// Maximum number of messages being displayed in the List before a scrollbar appears. Value '0' means no limit.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>7</code>.
					/// </summary>
					/// <param name="iMaxListed">New value for property <code>maxListed</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageBar setMaxListed(int iMaxListed);

					#endregion

					#region Methods for Property anchorSnapPoint

					/// <summary>
					/// Gets current value of property {@link #getAnchorSnapPoint anchorSnapPoint}.
					/// 
					/// Type: sap.ui.core.Popup.Dock SnapPoint of MessageBar over anchorId. Note: Use "begin" or "end" for RTL support. Note: "center" is not indicated, as positioning is only set once, either via the css "left" or the "right" attribute. Therefore a MessageBar will only be extended in one direction, as Messages come in.
					/// 
					/// Default value is <code>begin top</code>.
					/// </summary>
					/// <returns>Value of property <code>anchorSnapPoint</code></returns>
					public extern virtual string getAnchorSnapPoint();

					/// <summary>
					/// Sets a new value for property {@link #getAnchorSnapPoint anchorSnapPoint}.
					/// 
					/// Type: sap.ui.core.Popup.Dock SnapPoint of MessageBar over anchorId. Note: Use "begin" or "end" for RTL support. Note: "center" is not indicated, as positioning is only set once, either via the css "left" or the "right" attribute. Therefore a MessageBar will only be extended in one direction, as Messages come in.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>begin top</code>.
					/// </summary>
					/// <param name="sAnchorSnapPoint">New value for property <code>anchorSnapPoint</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageBar setAnchorSnapPoint(string sAnchorSnapPoint);

					#endregion

					#region Other methods

					/// <summary>
					/// Adds/updates a supplied list of messages. The MessageBar will appear if at least one message exists.
					/// </summary>
					/// <param name="aAMessages">Array of messages.</param>
					public extern virtual void addMessages(sap.ui.commons.Message[] aAMessages);

					/// <summary>
					/// Deletes all messages.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.MessageBar deleteAllMessages();

					/// <summary>
					/// Deletes a supplied list of messages. The MessageBar will disappear when no message remains.
					/// </summary>
					/// <param name="aIds">Messages IDs to be deleted.</param>
					public extern virtual void deleteMessages(string[] aIds);

					/// <summary>
					/// Deletes a supplied list of messages. The MessageBar will disappear when no message remains.
					/// </summary>
					/// <param name="aIds">Messages IDs to be deleted.</param>
					public extern virtual void deleteMessages(object[] aIds);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MessageBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MessageBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.MessageBar with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.MessageBar.
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
