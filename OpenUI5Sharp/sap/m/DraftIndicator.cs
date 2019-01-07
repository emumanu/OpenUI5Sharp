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
			/// A draft indicator is {@link sap.m.Label}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.DraftIndicator")]
			public abstract partial class DraftIndicator : sap.ui.core.Control
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
					/// State of the indicator. Could be "Saving", "Saved" and "Clear".
					/// </summary>
					public Union<sap.m.DraftIndicatorState, string, sap.ui.@base.ManagedObject.BindPropertyInfo> state;

					/// <summary>
					/// Minimum time in milliseconds for showing the draft indicator
					/// </summary>
					public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> minDisplayTime;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new DraftIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DraftIndicator(string sId, sap.m.DraftIndicator.Settings mSettings);

				/// <summary>
				/// Constructor for a new DraftIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern DraftIndicator(string sId);

				/// <summary>
				/// Constructor for a new DraftIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern DraftIndicator();

				/// <summary>
				/// Constructor for a new DraftIndicator.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern DraftIndicator(sap.m.DraftIndicator.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property state

				/// <summary>
				/// Gets current value of property {@link #getState state}.
				/// 
				/// State of the indicator. Could be "Saving", "Saved" and "Clear".
				/// 
				/// Default value is <code>Clear</code>.
				/// </summary>
				/// <returns>Value of property <code>state</code></returns>
				public extern virtual sap.m.DraftIndicatorState getState();

				/// <summary>
				/// Sets a new value for property {@link #getState state}.
				/// 
				/// State of the indicator. Could be "Saving", "Saved" and "Clear".
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Clear</code>.
				/// </summary>
				/// <param name="sState">New value for property <code>state</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DraftIndicator setState(sap.m.DraftIndicatorState sState);

				#endregion

				#region Methods for Property minDisplayTime

				/// <summary>
				/// Gets current value of property {@link #getMinDisplayTime minDisplayTime}.
				/// 
				/// Minimum time in milliseconds for showing the draft indicator
				/// 
				/// Default value is <code>1500</code>.
				/// </summary>
				/// <returns>Value of property <code>minDisplayTime</code></returns>
				public extern virtual int getMinDisplayTime();

				/// <summary>
				/// Sets a new value for property {@link #getMinDisplayTime minDisplayTime}.
				/// 
				/// Minimum time in milliseconds for showing the draft indicator
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>1500</code>.
				/// </summary>
				/// <param name="iMinDisplayTime">New value for property <code>minDisplayTime</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.DraftIndicator setMinDisplayTime(int iMinDisplayTime);

				#endregion

				#region Methods for Aggregation _label

				#endregion

				#region Other methods

				/// <summary>
				/// Clears the indicator state
				/// </summary>
				public extern virtual void clearDraftState();

				/// <summary>
				/// Creates a new subclass of class sap.m.DraftIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.DraftIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.DraftIndicator with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.DraftIndicator.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				/// <summary>
				/// Sets the indicator in "Saved" state
				/// </summary>
				public extern virtual void showDraftSaved();

				/// <summary>
				/// Sets the indicator in "Saving..." state
				/// </summary>
				public extern virtual void showDraftSaving();

				#endregion

				#endregion

			}
		}
	}
}
