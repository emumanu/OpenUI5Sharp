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
			/// The QuickViewCard control displays information of an object in a business-card format. It also allows this object to be linked to another object using one of the links. Clicking that link updates the information with the data of the linked object. Unlimited number of objects can be linked.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.QuickViewCard")]
			public partial class QuickViewCard : sap.m.QuickViewBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.QuickViewBase.Settings
				{
					/// <summary>
					/// Determines whether the browser displays the vertical scroll bar or simply cuts the content of the QuickViewCard.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> showVerticalScrollBar;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new QuickViewCard.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewCard(string sId, sap.m.QuickViewCard.Settings mSettings);

				/// <summary>
				/// Constructor for a new QuickViewCard.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern QuickViewCard(string sId);

				/// <summary>
				/// Constructor for a new QuickViewCard.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern QuickViewCard();

				/// <summary>
				/// Constructor for a new QuickViewCard.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewCard(sap.m.QuickViewCard.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property showVerticalScrollBar

				/// <summary>
				/// Gets current value of property {@link #getShowVerticalScrollBar showVerticalScrollBar}.
				/// 
				/// Determines whether the browser displays the vertical scroll bar or simply cuts the content of the QuickViewCard.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showVerticalScrollBar</code></returns>
				public extern virtual bool getShowVerticalScrollBar();

				/// <summary>
				/// Sets a new value for property {@link #getShowVerticalScrollBar showVerticalScrollBar}.
				/// 
				/// Determines whether the browser displays the vertical scroll bar or simply cuts the content of the QuickViewCard.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowVerticalScrollBar">New value for property <code>showVerticalScrollBar</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewCard setShowVerticalScrollBar(bool bShowVerticalScrollBar);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewCard with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.QuickViewBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewCard with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.QuickViewBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewCard with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.QuickViewBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.QuickViewCard.
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
