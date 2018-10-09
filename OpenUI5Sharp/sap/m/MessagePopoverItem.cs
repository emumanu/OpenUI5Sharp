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
			/// Items provide information about Error Messages in the page.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.MessagePopoverItem")]
			[Obsolete("Deprecated since 1.46. use MessageItem instead")]
			public partial class MessagePopoverItem : sap.m.MessageItem
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.MessageItem.Settings
				{
				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new MessagePopoverItem.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern MessagePopoverItem(string sId, sap.m.MessagePopoverItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new MessagePopoverItem.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern MessagePopoverItem(string sId);

				/// <summary>
				/// Constructor for a new MessagePopoverItem.
				/// </summary>
				public extern MessagePopoverItem();

				/// <summary>
				/// Constructor for a new MessagePopoverItem.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern MessagePopoverItem(sap.m.MessagePopoverItem.Settings mSettings);

				#endregion

				#region Methods

				/// <summary>
				/// Creates a new subclass of class sap.m.MessagePopoverItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.MessageItem.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessagePopoverItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.MessageItem.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.MessagePopoverItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.MessageItem.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.MessagePopoverItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

			}
		}
	}
}
