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
			public static partial class @base
			{
				/// <summary>
				/// An Event object consisting of an ID, a source and a map of parameters. Implements {@link sap.ui.base.Poolable} and therefore an event object in the event handler will be reset by {@link sap.ui.base.ObjectPool} after the event handler is done.
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class Event : sap.ui.@base.Object, sap.ui.@base.Poolable
				{
					#region Constructor

					/// <summary>
					/// Creates an event with the given <code>sId</code>, linked to the provided <code>oSource</code> and enriched with the <code>mParameters</code>.
					/// </summary>
					/// <param name="sId">The id of the event</param>
					/// <param name="oSource">The source of the event</param>
					/// <param name="mParameters">A map of parameters for this event</param>
					public extern Event(string sId, sap.ui.@base.EventProvider oSource, object mParameters);

					#endregion

					#region Methods

					/// <summary>
					/// Cancel bubbling of the event.
					/// 
					/// <b>Note:</b> This function only has an effect if the bubbling of the event is supported by the event source.
					/// </summary>
					public extern virtual void cancelBubble();

					/// <summary>
					/// Creates a new subclass of class sap.ui.base.Event with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.base.Event with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.base.Event with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns the id of the event.
					/// </summary>
					/// <returns>The id of the event</returns>
					public extern virtual string getId();

					/// <summary>
					/// Returns a metadata object for class sap.ui.base.Event.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns the value of the parameter with the given sName.
					/// </summary>
					/// <param name="sName">The name of the parameter to return</param>
					/// <returns>The value for the named parameter</returns>
					public extern virtual object getParameter(string sName);

					/// <summary>
					/// Returns all parameter values of the event keyed by their names.
					/// </summary>
					/// <returns>All parameters of the event keyed by name</returns>
					public extern virtual Map getParameters();

					/// <summary>
					/// Returns the event provider on which the event was fired.
					/// </summary>
					/// <returns>The source of the event</returns>
					public extern virtual sap.ui.@base.EventProvider getSource();

					/// <summary>
					/// Prevent the default action of this event.
					/// 
					/// <b>Note:</b> This function only has an effect if preventing the default action of the event is supported by the event source.
					/// </summary>
					public extern virtual void preventDefault();

					#region Methods of sap.ui.base.Poolable Interface

					/// <summary>
					/// Called by the object pool when this instance will be actived for a caller. The same method will be called after a new instance has been created by an otherwise exhausted pool.
					/// 
					/// If the caller provided any arguments to {@link sap.ui.base.ObjectPool#borrowObject} all arguments will be propagated to this method.
					/// </summary>
					public extern virtual void init();

					/// <summary>
					/// Called by the object pool when an instance is returned to the pool. While no specific implementation is required, poolable objects in general should clean all caller specific state (set to null) in this method to avoid memory leaks and to enforce garbage collection of the caller state.
					/// </summary>
					public extern virtual void reset();

					#endregion

					#endregion

				}
			}
		}
	}
}
