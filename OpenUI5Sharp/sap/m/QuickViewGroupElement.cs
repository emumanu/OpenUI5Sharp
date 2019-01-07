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
			/// QuickViewGroupElement is a combination of one label and another control (Link or Text) associated to this label.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.QuickViewGroupElement")]
			public partial class QuickViewGroupElement : sap.ui.core.Element
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Element.Settings
				{
					/// <summary>
					/// Determines whether the element should be visible on the screen.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// Specifies the text displayed below the associated label.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> label;

					/// <summary>
					/// Specifies the text of the control that associates with the label.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

					/// <summary>
					/// Specifies the address of the QuickViewGroupElement link. Works only with QuickViewGroupElement of type link.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> url;

					/// <summary>
					/// Specifies the target of the link - it works like the target property of the HTML <a> tag. Works only with QuickViewGroupElement of type link.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> target;

					/// <summary>
					/// Specifies the type of the displayed information - phone number, mobile number, e-mail, link, text or a link to another QuickViewPage. Default value is 'text'.
					/// </summary>
					public Union<sap.m.QuickViewGroupElementType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

					/// <summary>
					/// Specifies the ID of the QuickViewPage, which is opened from the link in the QuickViewGroupElement. Works only with QuickViewGroupElement of type pageLink.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> pageLinkId;

					/// <summary>
					/// The subject of the email. Works only with QuickViewGroupElement of type email.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> emailSubject;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new QuickViewGroupElement.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewGroupElement(string sId, sap.m.QuickViewGroupElement.Settings mSettings);

				/// <summary>
				/// Constructor for a new QuickViewGroupElement.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern QuickViewGroupElement(string sId);

				/// <summary>
				/// Constructor for a new QuickViewGroupElement.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern QuickViewGroupElement();

				/// <summary>
				/// Constructor for a new QuickViewGroupElement.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewGroupElement(sap.m.QuickViewGroupElement.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Determines whether the element should be visible on the screen.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern virtual bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Determines whether the element should be visible on the screen.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroupElement setVisible(bool bVisible);

				#endregion

				#region Methods for Property label

				/// <summary>
				/// Gets current value of property {@link #getLabel label}.
				/// 
				/// Specifies the text displayed below the associated label.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>label</code></returns>
				public extern virtual string getLabel();

				/// <summary>
				/// Sets a new value for property {@link #getLabel label}.
				/// 
				/// Specifies the text displayed below the associated label.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sLabel">New value for property <code>label</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroupElement setLabel(string sLabel);

				#endregion

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// Specifies the text of the control that associates with the label.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual string getValue();

				/// <summary>
				/// Sets a new value for property {@link #getValue value}.
				/// 
				/// Specifies the text of the control that associates with the label.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sValue">New value for property <code>value</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroupElement setValue(string sValue);

				#endregion

				#region Methods for Property url

				/// <summary>
				/// Gets current value of property {@link #getUrl url}.
				/// 
				/// Specifies the address of the QuickViewGroupElement link. Works only with QuickViewGroupElement of type link.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>url</code></returns>
				public extern virtual string getUrl();

				/// <summary>
				/// Sets a new value for property {@link #getUrl url}.
				/// 
				/// Specifies the address of the QuickViewGroupElement link. Works only with QuickViewGroupElement of type link.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sUrl">New value for property <code>url</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroupElement setUrl(string sUrl);

				#endregion

				#region Methods for Property target

				/// <summary>
				/// Gets current value of property {@link #getTarget target}.
				/// 
				/// Specifies the target of the link - it works like the target property of the HTML <a> tag. Works only with QuickViewGroupElement of type link.
				/// 
				/// Default value is <code>_blank</code>.
				/// </summary>
				/// <returns>Value of property <code>target</code></returns>
				public extern virtual string getTarget();

				/// <summary>
				/// Sets a new value for property {@link #getTarget target}.
				/// 
				/// Specifies the target of the link - it works like the target property of the HTML <a> tag. Works only with QuickViewGroupElement of type link.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>_blank</code>.
				/// </summary>
				/// <param name="sTarget">New value for property <code>target</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroupElement setTarget(string sTarget);

				#endregion

				#region Methods for Property type

				/// <summary>
				/// Gets current value of property {@link #getType type}.
				/// 
				/// Specifies the type of the displayed information - phone number, mobile number, e-mail, link, text or a link to another QuickViewPage. Default value is 'text'.
				/// 
				/// Default value is <code>text</code>.
				/// </summary>
				/// <returns>Value of property <code>type</code></returns>
				public extern virtual sap.m.QuickViewGroupElementType getType();

				/// <summary>
				/// Sets a new value for property {@link #getType type}.
				/// 
				/// Specifies the type of the displayed information - phone number, mobile number, e-mail, link, text or a link to another QuickViewPage. Default value is 'text'.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>text</code>.
				/// </summary>
				/// <param name="sType">New value for property <code>type</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroupElement setType(sap.m.QuickViewGroupElementType sType);

				#endregion

				#region Methods for Property pageLinkId

				/// <summary>
				/// Gets current value of property {@link #getPageLinkId pageLinkId}.
				/// 
				/// Specifies the ID of the QuickViewPage, which is opened from the link in the QuickViewGroupElement. Works only with QuickViewGroupElement of type pageLink.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>pageLinkId</code></returns>
				public extern virtual string getPageLinkId();

				/// <summary>
				/// Sets a new value for property {@link #getPageLinkId pageLinkId}.
				/// 
				/// Specifies the ID of the QuickViewPage, which is opened from the link in the QuickViewGroupElement. Works only with QuickViewGroupElement of type pageLink.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sPageLinkId">New value for property <code>pageLinkId</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroupElement setPageLinkId(string sPageLinkId);

				#endregion

				#region Methods for Property emailSubject

				/// <summary>
				/// Gets current value of property {@link #getEmailSubject emailSubject}.
				/// 
				/// The subject of the email. Works only with QuickViewGroupElement of type email.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>emailSubject</code></returns>
				public extern virtual string getEmailSubject();

				/// <summary>
				/// Sets a new value for property {@link #getEmailSubject emailSubject}.
				/// 
				/// The subject of the email. Works only with QuickViewGroupElement of type email.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sEmailSubject">New value for property <code>emailSubject</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroupElement setEmailSubject(string sEmailSubject);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewGroupElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewGroupElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewGroupElement with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.QuickViewGroupElement.
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
