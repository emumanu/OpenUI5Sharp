using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class f
		{
			public static partial class routing
			{
				[External]
				[Namespace(false)]
				[Name("sap.f.routing.Targets")]
				public partial class Targets : sap.ui.core.routing.Targets
				{
					#region Constructor

					/// <summary>
					/// Provides a convenient way for placing views into the correct containers of your application. The sap.f extension of Targets also handles the triggering of page navigation when the target control is a {@link sap.f.FlexibleColumnLayout}. Other controls are also allowed, but the extra parameters viewLevel, transition and transitionParameters are ignored and it will behave like {@link sap.ui.core.routing.Targets}. When a target is displayed, dialogs will be closed. To change this use {@link #getTargetHandler} and {@link sap.f.routing.TargetHandler#setCloseDialogs}.
					/// </summary>
					/// <param name="oOptions"></param>
					public extern Targets(sap.m.RoutingTargetsOptions oOptions);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.f.routing.Targets with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.routing.Targets.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.f.routing.Targets with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.routing.Targets.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.f.routing.Targets with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.routing.Targets.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.f.routing.Targets.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the TargetHandler instance.
					/// </summary>
					/// <returns>the TargetHandler instance</returns>
					public extern virtual sap.f.routing.TargetHandler getTargetHandler();

					#endregion

				}
			}
		}
	}
}
