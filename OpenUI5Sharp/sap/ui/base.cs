using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			/// <summary>
			/// SAPUI5 base classes
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.ui.base")]
			public static partial class @base
			{
				/// <summary>
				/// Contract for objects that can be pooled by ObjectPool
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.base.Poolable")]
				public partial interface Poolable
				{
					#region Methods

					/// <summary>
					/// Called by the object pool when this instance will be actived for a caller. The same method will be called after a new instance has been created by an otherwise exhausted pool.
					/// 
					/// If the caller provided any arguments to {@link sap.ui.base.ObjectPool#borrowObject} all arguments will be propagated to this method.
					/// </summary>
					void init();

					/// <summary>
					/// Called by the object pool when an instance is returned to the pool. While no specific implementation is required, poolable objects in general should clean all caller specific state (set to null) in this method to avoid memory leaks and to enforce garbage collection of the caller state.
					/// </summary>
					void reset();

					#endregion

				}
			}
		}
	}
}
