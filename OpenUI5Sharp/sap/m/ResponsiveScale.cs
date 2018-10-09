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
			/// <strong><i>Overview</i></strong>
			/// 
			/// A {@link sap.m.Slider} element represents a scale with tickmarks and labels. The purpose of the element is to decouple the scale logic from other controls i.e. Slider / RangeSlider
			/// 
			/// The most important properties of the ResponsiveScale are: <ul> <li> tickmarksBetweenLabels - Puts a label on every N-th tickmark.</li> </ul>
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ResponsiveScale")]
			public partial class ResponsiveScale : sap.ui.core.Element, sap.m.IScale
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
					/// Put a label on every N-th tickmark.
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> tickmarksBetweenLabels;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ResponsiveScale</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ResponsiveScale(string sId, sap.m.ResponsiveScale.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ResponsiveScale</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ResponsiveScale(string sId);

				/// <summary>
				/// Constructor for a new <code>ResponsiveScale</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ResponsiveScale();

				/// <summary>
				/// Constructor for a new <code>ResponsiveScale</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ResponsiveScale(sap.m.ResponsiveScale.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property tickmarksBetweenLabels

				/// <summary>
				/// Gets current value of property {@link #getTickmarksBetweenLabels tickmarksBetweenLabels}.
				/// 
				/// Put a label on every N-th tickmark.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <returns>Value of property <code>tickmarksBetweenLabels</code></returns>
				public extern virtual int getTickmarksBetweenLabels();

				/// <summary>
				/// Sets a new value for property {@link #getTickmarksBetweenLabels tickmarksBetweenLabels}.
				/// 
				/// Put a label on every N-th tickmark.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>0</code>.
				/// </summary>
				/// <param name="iTickmarksBetweenLabels">New value for property <code>tickmarksBetweenLabels</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ResponsiveScale setTickmarksBetweenLabels(int iTickmarksBetweenLabels);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ResponsiveScale with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ResponsiveScale with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ResponsiveScale with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ResponsiveScale.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Shows/hides tickmarks when some limitations are met. Implements responsiveness of the tickmarks.
				/// </summary>
				/// <param name="oEvent">The event object passed.</param>
				private extern void handleResize(jquery.JQuery.Event oEvent);

				#endregion

				#endregion

			}
		}
	}
}
