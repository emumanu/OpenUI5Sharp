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
				/// Manages a pool of objects all of the same type; the type has to be specified at pool construction time.
				/// 
				/// Maintains a list of free objects of the given type. If {@link sap.ui.base.ObjectPool.prototype.borrowObject} is called, an existing free object is taken from the pool and the <code>init</code> method is called on this object.
				/// 
				/// When no longer needed, any borrowed object should be returned to the pool by calling {@link #returnObject}. At that point in time, the reset method is called on the object and the object is added to the list of free objects.
				/// 
				/// See {@link sap.ui.base.Poolable} for a description of the contract for poolable objects.
				/// 
				/// Example: <pre>
				///   this.oEventPool = new sap.ui.base.ObjectPool(sap.ui.base.Event);
				///   var oEvent = this.oEventPool.borrowObject(iEventId, mParameters);
				/// </pre>
				/// </summary>
				[External]
				[Namespace(false)]
				public partial class ObjectPool : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Creates an ObjectPool instance based on the given oObjectClass.<br/>; If there is a free pooled instance, returns that one, otherwise creates a new one.<br/>; In order to be maintained by the ObjectPool, oObjectClass must implement methods described in the class description.
					/// </summary>
					/// <param name="oObjectClass">constructor for the class of objects that this pool should manage</param>
					public extern ObjectPool(object oObjectClass);

					#endregion

					#region Methods

					/// <summary>
					/// Borrows a free object from the pool. Any arguments to this method are forwarded to the init method of the borrowed object.
					/// </summary>
					/// <param name="any">optional initialization parameters for the borrowed object</param>
					/// <returns>the borrowed object of the same type that has been specified for this pool</returns>
					public extern virtual object borrowObject(object any);

					/// <summary>
					/// Borrows a free object from the pool. Any arguments to this method are forwarded to the init method of the borrowed object.
					/// </summary>
					/// <returns>the borrowed object of the same type that has been specified for this pool</returns>
					public extern virtual object borrowObject();

					/// <summary>
					/// Creates a new subclass of class sap.ui.base.ObjectPool with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.base.ObjectPool with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.base.ObjectPool with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.base.ObjectPool.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Returns an object to the pool. The object must have been borrowed from this pool beforehand. The reset method is called on the object before it is added to the set of free objects.
					/// </summary>
					/// <param name="oObject">the object to return to the pool</param>
					public extern virtual void returnObject(object oObject);

					#endregion

				}
			}
		}
	}
}
