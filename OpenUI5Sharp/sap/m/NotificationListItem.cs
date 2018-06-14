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
			/// The NotificationListItem control shows notifications to the user. <h4>Structure</h4> The notification item holds properties for the following elements: <ul> <li><code>description</code> - additional detail text.</li> <li><code>hideShowMoreButton</code> - visibility of the "Show More" button.</li> <li><code>truncate</code> - determines if title and description are truncated to the first two lines (usually needed on mobile devices).</li> </ul> For each item you can set some additional status information about the item processing by adding a {@link sap.m.MessageStrip} to the <code>processingMessage</code> aggregation.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class NotificationListItem : sap.m.NotificationListBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.NotificationListBase.Settings
				{
					/// <summary>
					/// Determines the description of the NotificationListItem.
					/// </summary>
					public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> description;

					/// <summary>
					/// Determines if the text in the title and the description of the notification are truncated to the first two lines.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> truncate;

					/// <summary>
					/// Determines if the "Show More" button should be hidden.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> hideShowMoreButton;

					/// <summary>
					/// The sap.m.MessageStrip control that holds the information about any error that may occur when pressing the notification buttons
					/// </summary>
					public Union<sap.m.MessageStrip, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> processingMessage;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new NotificationListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NotificationListItem(string sId, sap.m.NotificationListItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new NotificationListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern NotificationListItem(string sId);

				/// <summary>
				/// Constructor for a new NotificationListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern NotificationListItem();

				/// <summary>
				/// Constructor for a new NotificationListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NotificationListItem(sap.m.NotificationListItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property description

				/// <summary>
				/// Gets current value of property {@link #getDescription description}.
				/// 
				/// Determines the description of the NotificationListItem.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>description</code></returns>
				public extern virtual string getDescription();

				/// <summary>
				/// Sets the description.
				/// </summary>
				/// <param name="description">Description.</param>
				/// <returns>NotificationListItem reference for chaining.</returns>
				public extern virtual sap.m.NotificationListItem setDescription(string description);

				#endregion

				#region Methods for Property truncate

				/// <summary>
				/// Gets current value of property {@link #getTruncate truncate}.
				/// 
				/// Determines if the text in the title and the description of the notification are truncated to the first two lines.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>truncate</code></returns>
				public extern virtual bool getTruncate();

				/// <summary>
				/// Sets a new value for property {@link #getTruncate truncate}.
				/// 
				/// Determines if the text in the title and the description of the notification are truncated to the first two lines.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bTruncate">New value for property <code>truncate</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListItem setTruncate(bool bTruncate);

				#endregion

				#region Methods for Property hideShowMoreButton

				/// <summary>
				/// Gets current value of property {@link #getHideShowMoreButton hideShowMoreButton}.
				/// 
				/// Determines if the "Show More" button should be hidden.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <returns>Value of property <code>hideShowMoreButton</code></returns>
				public extern virtual bool getHideShowMoreButton();

				/// <summary>
				/// Sets a new value for property {@link #getHideShowMoreButton hideShowMoreButton}.
				/// 
				/// Determines if the "Show More" button should be hidden.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>false</code>.
				/// </summary>
				/// <param name="bHideShowMoreButton">New value for property <code>hideShowMoreButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListItem setHideShowMoreButton(bool bHideShowMoreButton);

				#endregion

				#region Methods for Aggregation processingMessage

				/// <summary>
				/// Gets content of aggregation {@link #getProcessingMessage processingMessage}.
				/// 
				/// The sap.m.MessageStrip control that holds the information about any error that may occur when pressing the notification buttons
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.MessageStrip getProcessingMessage();

				/// <summary>
				/// Destroys the processingMessage in the aggregation {@link #getProcessingMessage processingMessage}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListItem destroyProcessingMessage();

				/// <summary>
				/// Sets the aggregated {@link #getProcessingMessage processingMessage}.
				/// </summary>
				/// <param name="oProcessingMessage">The processingMessage to set</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NotificationListItem setProcessingMessage(sap.m.MessageStrip oProcessingMessage);

				#endregion

				#region Methods for Aggregation _bodyText

				#endregion

				#region Other methods

				/// <summary>
				/// Registers resize handler.
				/// </summary>
				public extern virtual void _registerResize();

				/// <summary>
				/// Clones list item.
				/// </summary>
				/// <returns>NotificationListItem reference for chaining.</returns>
				public extern virtual sap.m.NotificationListItem clone();

				/// <summary>
				/// Creates a new subclass of class sap.m.NotificationListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.NotificationListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.NotificationListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.NotificationListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.NotificationListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.NotificationListBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.NotificationListItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Sets initial values for the control.
				/// </summary>
				public extern override void init();

				/// <summary>
				/// Overwrites onAfterRendering
				/// </summary>
				public extern override void onAfterRendering();

				/// <summary>
				/// Overwrites onBeforeRendering
				/// </summary>
				public extern override void onBeforeRendering();

				/// <summary>
				/// Sets the author picture for list item.
				/// </summary>
				/// <param name="authorPicture">Picture url in string format.</param>
				/// <param name="suppressInvalidation">Indication for suppressing invalidation.</param>
				/// <returns>NotificationListItem reference for chaining.</returns>
				public extern virtual sap.m.NotificationListItem setAuthorPicture(string authorPicture, bool suppressInvalidation);

				/// <summary>
				/// Sets the DateTime.
				/// </summary>
				/// <param name="dateTime">DateTime.</param>
				/// <returns>NotificationListBase reference for chaining.</returns>
				public extern virtual sap.m.NotificationListBase setDatetime(object dateTime);

				/// <summary>
				/// Sets the priority of the list item.
				/// </summary>
				/// <param name="priority">Priority of the list item.</param>
				/// <param name="suppressInvalidation">Indication for suppressing invalidation.</param>
				/// <returns>NotificationListItem reference for chaining.</returns>
				public extern virtual sap.m.NotificationListItem setPriority(string priority, bool suppressInvalidation);

				/// <summary>
				/// Sets the unread text.
				/// </summary>
				/// <param name="unread">Indication of unread list item.</param>
				/// <returns>NotificationListItem reference for chaining.</returns>
				public extern virtual sap.m.NotificationListItem setUnread(bool unread);

				#endregion

				#endregion

			}
		}
	}
}
