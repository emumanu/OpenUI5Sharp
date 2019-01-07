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
			/// The control provides a set of properties for text, sender information, time stamp. Beginning with release 1.23 the new feature expand / collapse was introduced, which uses the property maxCharacters. Beginning with release 1.44, sap.m.FormattedText was introduced which allows html formatted text to be displayed
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.FeedListItem")]
			public partial class FeedListItem : sap.m.ListItemBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ListItemBase.Settings
				{
					/// <summary>
					/// Icon to be displayed as graphical element within the FeedListItem. This can be an image or an icon from the icon font. If no icon is provided, a default person-placeholder icon is displayed. Icon is only shown if showIcon = true.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> icon;

					/// <summary>
					/// Icon displayed when the list item is active.
					/// </summary>
					public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> activeIcon;

					/// <summary>
					/// Sender of the chunk
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> sender;

					/// <summary>
					/// The FeedListItem text. It supports html formatted tags as described in the documentation of sap.m.FormattedText
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

					/// <summary>
					/// The Info text.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> info;

					/// <summary>
					/// This chunks timestamp
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> timestamp;

					/// <summary>
					/// If true, sender string is a link, which will fire 'senderPress' events. If false, sender is normal text.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> senderActive;

					/// <summary>
					/// If true, icon is a link, which will fire 'iconPress' events. If false, icon is normal image
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconActive;

					/// <summary>
					/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
					/// 
					/// If bandwidth is the key for the application, set this value to false.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> iconDensityAware;

					/// <summary>
					/// If set to "true" (default), icons will be displayed, if set to false icons are hidden
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showIcon;

					/// <summary>
					/// Determines whether strings that appear to be links will be converted to HTML anchor tags, and what are the criteria for recognizing them.
					/// </summary>
					public Union<sap.m.LinkConversion, string, sap.ui.@base.ManagedObject.BindPropertyInfo> convertLinksToAnchorTags;

					/// <summary>
					/// Determines the target attribute of the generated HTML anchor tags. Note: Applicable only if ConvertLinksToAnchorTags property is used with a value other than sap.m.LinkConversion.None. Options are the standard values for the target attribute of the HTML anchor tag: _self, _top, _blank, _parent, _search.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> convertedLinksDefaultTarget;

					/// <summary>
					/// The expand and collapse feature is set by default and uses 300 characters on mobile devices and 500 characters on desktops as limits. Based on these values, the text of the FeedListItem is collapsed once text reaches these limits. In this case, only the specified number of characters is displayed. By clicking on the text link More, the entire text can be displayed. The text link Less collapses the text. The application is able to set the value to its needs.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> maxCharacters;

					/// <summary>
					/// Contains {@link sap.m.FeedListItemAction elements} that are displayed in the action sheet.
					/// </summary>
					public Union<sap.m.FeedListItemAction[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> actions;

					/// <summary>
					/// Event is fired when name of the sender is pressed.
					/// </summary>
					public sap.m.FeedListItem.PressDelegate senderPress;

					/// <summary>
					/// Event is fired when the icon is pressed.
					/// </summary>
					public sap.m.FeedListItem.PressDelegate iconPress;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class PressInfo
				{
					/// <summary>
					/// Dom reference of the feed item's icon to be used for positioning.
					/// </summary>
					public string domRef;

					/// <summary>
					/// Function to retrieve the DOM reference for the <code>iconPress</code> event. The function returns the DOM element of the icon or null
					/// </summary>
					public object getDomRef;

				}

				#endregion

				#region Delegates

				public delegate void PressDelegate(sap.ui.@base.Event<sap.m.FeedListItem.PressInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new FeedListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern FeedListItem(string sId, sap.m.FeedListItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new FeedListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern FeedListItem(string sId);

				/// <summary>
				/// Constructor for a new FeedListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern FeedListItem();

				/// <summary>
				/// Constructor for a new FeedListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern FeedListItem(sap.m.FeedListItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property icon

				/// <summary>
				/// Gets current value of property {@link #getIcon icon}.
				/// 
				/// Icon to be displayed as graphical element within the FeedListItem. This can be an image or an icon from the icon font. If no icon is provided, a default person-placeholder icon is displayed. Icon is only shown if showIcon = true.
				/// </summary>
				/// <returns>Value of property <code>icon</code></returns>
				public extern virtual sap.ui.core.URI getIcon();

				/// <summary>
				/// Sets a new value for property {@link #getIcon icon}.
				/// 
				/// Icon to be displayed as graphical element within the FeedListItem. This can be an image or an icon from the icon font. If no icon is provided, a default person-placeholder icon is displayed. Icon is only shown if showIcon = true.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sIcon">New value for property <code>icon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setIcon(sap.ui.core.URI sIcon);

				#endregion

				#region Methods for Property activeIcon

				/// <summary>
				/// Gets current value of property {@link #getActiveIcon activeIcon}.
				/// 
				/// Icon displayed when the list item is active.
				/// </summary>
				/// <returns>Value of property <code>activeIcon</code></returns>
				public extern virtual sap.ui.core.URI getActiveIcon();

				/// <summary>
				/// Sets a new value for property {@link #getActiveIcon activeIcon}.
				/// 
				/// Icon displayed when the list item is active.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sActiveIcon">New value for property <code>activeIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setActiveIcon(sap.ui.core.URI sActiveIcon);

				#endregion

				#region Methods for Property sender

				/// <summary>
				/// Gets current value of property {@link #getSender sender}.
				/// 
				/// Sender of the chunk
				/// </summary>
				/// <returns>Value of property <code>sender</code></returns>
				public extern virtual string getSender();

				/// <summary>
				/// Sets a new value for property {@link #getSender sender}.
				/// 
				/// Sender of the chunk
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSender">New value for property <code>sender</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setSender(string sSender);

				#endregion

				#region Methods for Property text

				/// <summary>
				/// Gets current value of property {@link #getText text}.
				/// 
				/// The FeedListItem text. It supports html formatted tags as described in the documentation of sap.m.FormattedText
				/// </summary>
				/// <returns>Value of property <code>text</code></returns>
				public extern virtual string getText();

				/// <summary>
				/// Sets a new value for property {@link #getText text}.
				/// 
				/// The FeedListItem text. It supports html formatted tags as described in the documentation of sap.m.FormattedText
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sText">New value for property <code>text</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setText(string sText);

				#endregion

				#region Methods for Property info

				/// <summary>
				/// Gets current value of property {@link #getInfo info}.
				/// 
				/// The Info text.
				/// </summary>
				/// <returns>Value of property <code>info</code></returns>
				public extern virtual string getInfo();

				/// <summary>
				/// Sets a new value for property {@link #getInfo info}.
				/// 
				/// The Info text.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sInfo">New value for property <code>info</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setInfo(string sInfo);

				#endregion

				#region Methods for Property timestamp

				/// <summary>
				/// Gets current value of property {@link #getTimestamp timestamp}.
				/// 
				/// This chunks timestamp
				/// </summary>
				/// <returns>Value of property <code>timestamp</code></returns>
				public extern virtual string getTimestamp();

				/// <summary>
				/// Sets a new value for property {@link #getTimestamp timestamp}.
				/// 
				/// This chunks timestamp
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sTimestamp">New value for property <code>timestamp</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setTimestamp(string sTimestamp);

				#endregion

				#region Methods for Property senderActive

				/// <summary>
				/// Gets current value of property {@link #getSenderActive senderActive}.
				/// 
				/// If true, sender string is a link, which will fire 'senderPress' events. If false, sender is normal text.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>senderActive</code></returns>
				public extern virtual bool getSenderActive();

				/// <summary>
				/// Sets a new value for property {@link #getSenderActive senderActive}.
				/// 
				/// If true, sender string is a link, which will fire 'senderPress' events. If false, sender is normal text.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bSenderActive">New value for property <code>senderActive</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setSenderActive(bool bSenderActive);

				#endregion

				#region Methods for Property iconActive

				/// <summary>
				/// Gets current value of property {@link #getIconActive iconActive}.
				/// 
				/// If true, icon is a link, which will fire 'iconPress' events. If false, icon is normal image
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>iconActive</code></returns>
				public extern virtual bool getIconActive();

				/// <summary>
				/// Sets a new value for property {@link #getIconActive iconActive}.
				/// 
				/// If true, icon is a link, which will fire 'iconPress' events. If false, icon is normal image
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconActive">New value for property <code>iconActive</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setIconActive(bool bIconActive);

				#endregion

				#region Methods for Property iconDensityAware

				/// <summary>
				/// Gets current value of property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
				/// 
				/// If bandwidth is the key for the application, set this value to false.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>iconDensityAware</code></returns>
				public extern virtual bool getIconDensityAware();

				/// <summary>
				/// Sets a new value for property {@link #getIconDensityAware iconDensityAware}.
				/// 
				/// By default, this is set to true but then one or more requests are sent trying to get the density perfect version of image if this version of image doesn't exist on the server.
				/// 
				/// If bandwidth is the key for the application, set this value to false.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bIconDensityAware">New value for property <code>iconDensityAware</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setIconDensityAware(bool bIconDensityAware);

				#endregion

				#region Methods for Property showIcon

				/// <summary>
				/// Gets current value of property {@link #getShowIcon showIcon}.
				/// 
				/// If set to "true" (default), icons will be displayed, if set to false icons are hidden
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showIcon</code></returns>
				public extern virtual bool getShowIcon();

				/// <summary>
				/// Sets a new value for property {@link #getShowIcon showIcon}.
				/// 
				/// If set to "true" (default), icons will be displayed, if set to false icons are hidden
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowIcon">New value for property <code>showIcon</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setShowIcon(bool bShowIcon);

				#endregion

				#region Methods for Property convertLinksToAnchorTags

				/// <summary>
				/// Gets current value of property {@link #getConvertLinksToAnchorTags convertLinksToAnchorTags}.
				/// 
				/// Determines whether strings that appear to be links will be converted to HTML anchor tags, and what are the criteria for recognizing them.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <returns>Value of property <code>convertLinksToAnchorTags</code></returns>
				public extern virtual sap.m.LinkConversion getConvertLinksToAnchorTags();

				/// <summary>
				/// Sets a new value for property {@link #getConvertLinksToAnchorTags convertLinksToAnchorTags}.
				/// 
				/// Determines whether strings that appear to be links will be converted to HTML anchor tags, and what are the criteria for recognizing them.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>None</code>.
				/// </summary>
				/// <param name="sConvertLinksToAnchorTags">New value for property <code>convertLinksToAnchorTags</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setConvertLinksToAnchorTags(sap.m.LinkConversion sConvertLinksToAnchorTags);

				#endregion

				#region Methods for Property convertedLinksDefaultTarget

				/// <summary>
				/// Gets current value of property {@link #getConvertedLinksDefaultTarget convertedLinksDefaultTarget}.
				/// 
				/// Determines the target attribute of the generated HTML anchor tags. Note: Applicable only if ConvertLinksToAnchorTags property is used with a value other than sap.m.LinkConversion.None. Options are the standard values for the target attribute of the HTML anchor tag: _self, _top, _blank, _parent, _search.
				/// 
				/// Default value is <code>_blank</code>.
				/// </summary>
				/// <returns>Value of property <code>convertedLinksDefaultTarget</code></returns>
				public extern virtual string getConvertedLinksDefaultTarget();

				/// <summary>
				/// Sets a new value for property {@link #getConvertedLinksDefaultTarget convertedLinksDefaultTarget}.
				/// 
				/// Determines the target attribute of the generated HTML anchor tags. Note: Applicable only if ConvertLinksToAnchorTags property is used with a value other than sap.m.LinkConversion.None. Options are the standard values for the target attribute of the HTML anchor tag: _self, _top, _blank, _parent, _search.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>_blank</code>.
				/// </summary>
				/// <param name="sConvertedLinksDefaultTarget">New value for property <code>convertedLinksDefaultTarget</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setConvertedLinksDefaultTarget(string sConvertedLinksDefaultTarget);

				#endregion

				#region Methods for Property maxCharacters

				/// <summary>
				/// Gets current value of property {@link #getMaxCharacters maxCharacters}.
				/// 
				/// The expand and collapse feature is set by default and uses 300 characters on mobile devices and 500 characters on desktops as limits. Based on these values, the text of the FeedListItem is collapsed once text reaches these limits. In this case, only the specified number of characters is displayed. By clicking on the text link More, the entire text can be displayed. The text link Less collapses the text. The application is able to set the value to its needs.
				/// </summary>
				/// <returns>Value of property <code>maxCharacters</code></returns>
				public extern virtual int getMaxCharacters();

				/// <summary>
				/// Sets a new value for property {@link #getMaxCharacters maxCharacters}.
				/// 
				/// The expand and collapse feature is set by default and uses 300 characters on mobile devices and 500 characters on desktops as limits. Based on these values, the text of the FeedListItem is collapsed once text reaches these limits. In this case, only the specified number of characters is displayed. By clicking on the text link More, the entire text can be displayed. The text link Less collapses the text. The application is able to set the value to its needs.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="iMaxCharacters">New value for property <code>maxCharacters</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem setMaxCharacters(int iMaxCharacters);

				#endregion

				#region Methods for Aggregation actions

				/// <summary>
				/// Gets content of aggregation {@link #getActions actions}.
				/// 
				/// Contains {@link sap.m.FeedListItemAction elements} that are displayed in the action sheet.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.FeedListItemAction[] getActions();

				/// <summary>
				/// Destroys all the actions in the aggregation {@link #getActions actions}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem destroyActions();

				/// <summary>
				/// Inserts a action into the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the action should be inserted at; for a negative value of <code>iIndex</code>, the action is inserted at position 0; for a value greater than the current size of the aggregation, the action is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem insertAction(sap.m.FeedListItemAction oAction, int iIndex);

				/// <summary>
				/// Adds some action to the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="oAction">The action to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem addAction(sap.m.FeedListItemAction oAction);

				/// <summary>
				/// Removes a action from the aggregation {@link #getActions actions}.
				/// </summary>
				/// <param name="vAction">The action to remove or its index or id</param>
				/// <returns>The removed action or <code>null</code></returns>
				public extern virtual sap.m.FeedListItemAction removeAction(Union<int, string, sap.m.FeedListItemAction> vAction);

				/// <summary>
				/// Checks for the provided <code>sap.m.FeedListItemAction</code> in the aggregation {@link #getActions actions}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oAction">The action whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfAction(sap.m.FeedListItemAction oAction);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getActions actions}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.FeedListItemAction[] removeAllActions();

				#endregion

				#region Methods for Aggregation _text

				#endregion

				#region Methods for Aggregation _actionSheet

				#endregion

				#region Methods for Aggregation _actionButton

				#endregion

				#region Methods for Event senderPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:senderPress senderPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedListItem</code> itself.
				/// 
				/// Event is fired when name of the sender is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FeedListItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem attachSenderPress(object oData, sap.m.FeedListItem.PressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:senderPress senderPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedListItem</code> itself.
				/// 
				/// Event is fired when name of the sender is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem attachSenderPress(object oData, sap.m.FeedListItem.PressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:senderPress senderPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedListItem</code> itself.
				/// 
				/// Event is fired when name of the sender is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem attachSenderPress(sap.m.FeedListItem.PressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:senderPress senderPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedListItem</code> itself.
				/// 
				/// Event is fired when name of the sender is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FeedListItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem attachSenderPress(sap.m.FeedListItem.PressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:senderPress senderPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem detachSenderPress(sap.m.FeedListItem.PressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:senderPress senderPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem fireSenderPress(sap.m.FeedListItem.PressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:senderPress senderPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem fireSenderPress();

				#endregion

				#region Methods for Event iconPress

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconPress iconPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedListItem</code> itself.
				/// 
				/// Event is fired when the icon is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FeedListItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem attachIconPress(object oData, sap.m.FeedListItem.PressDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconPress iconPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedListItem</code> itself.
				/// 
				/// Event is fired when the icon is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem attachIconPress(object oData, sap.m.FeedListItem.PressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconPress iconPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedListItem</code> itself.
				/// 
				/// Event is fired when the icon is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem attachIconPress(sap.m.FeedListItem.PressDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:iconPress iconPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.FeedListItem</code> itself.
				/// 
				/// Event is fired when the icon is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.FeedListItem</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem attachIconPress(sap.m.FeedListItem.PressDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:iconPress iconPress} event of this <code>sap.m.FeedListItem</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem detachIconPress(sap.m.FeedListItem.PressDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:iconPress iconPress} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem fireIconPress(sap.m.FeedListItem.PressInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:iconPress iconPress} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.FeedListItem fireIconPress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.FeedListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.FeedListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.FeedListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.FeedListItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Redefinition of sap.m.ListItemBase.setType: type = "sap.m.ListType.Navigation" behaves like type = "sap.m.ListType.Active" for a FeedListItem
				/// </summary>
				/// <param name="type">new value for property type</param>
				/// <returns>this allows method chaining</returns>
				public extern virtual sap.m.FeedListItem setType(sap.m.ListType type);

				/// <summary>
				/// Redefinition of sap.m.ListItemBase.setUnread: Unread is not supported for FeedListItem
				/// </summary>
				/// <param name="value">new value for property unread is ignored</param>
				/// <returns>this allows method chaining</returns>
				public extern virtual sap.m.FeedListItem setUnread(bool value);

				#endregion

				#endregion

			}
		}
	}
}
