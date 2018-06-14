using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// Provides a trigger that triggers in a set interval and calls all registered listeners. If the interval is <= 0 the trigger is switched off and won't trigger at all.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class IntervalTrigger : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Creates an instance of EventBus.
					/// </summary>
					/// <param name="iInterval">is the interval the trigger should be used. If the trigger is >0 triggering starts/runs and if the interval is set to <=0 triggering stops.</param>
					public extern IntervalTrigger(int iInterval);

					#endregion

					#region Methods

					/// <summary>
					/// Adds a listener to the list that should be triggered.
					/// </summary>
					/// <param name="fnFunction">is the called function that should be called when the trigger want to trigger the listener.</param>
					/// <param name="oListener">that should be triggered.</param>
					public extern virtual void addListener(object fnFunction, object oListener);

					/// <summary>
					/// Adds a listener to the list that should be triggered.
					/// </summary>
					/// <param name="fnFunction">is the called function that should be called when the trigger want to trigger the listener.</param>
					public extern virtual void addListener(object fnFunction);

					/// <summary>
					/// Destructor method for objects.
					/// </summary>
					public extern override void destroy();

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.IntervalTrigger with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.IntervalTrigger with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.core.IntervalTrigger with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					public extern virtual void getInterface();

					/// <summary>
					/// Returns a metadata object for class sap.ui.core.IntervalTrigger.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Removes corresponding listener from list.
					/// </summary>
					/// <param name="fnFunction">is the previously registered function</param>
					/// <param name="oListener">that should be removed</param>
					public extern virtual void removeListener(object fnFunction, object oListener);

					/// <summary>
					/// Removes corresponding listener from list.
					/// </summary>
					/// <param name="fnFunction">is the previously registered function</param>
					public extern virtual void removeListener(object fnFunction);

					/// <summary>
					/// Sets the trigger interval. If the value is >0 triggering will start if there are any registered listeners. If the interval is set to <=0 triggering will stop.
					/// </summary>
					/// <param name="iInterval">sets the interval in milliseconds when a new triggering should occur.</param>
					public extern virtual void setInterval(int iInterval);

					#endregion

				}
			}
		}
	}
}
