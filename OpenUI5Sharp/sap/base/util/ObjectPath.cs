using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class @base
		{
			public static partial class util
			{
				/// <summary>
				/// Manages an object path.
				/// 
				/// The object path can be just created with {@link #.create}, then an empty nested object path will be created from the provided string. If a value is set for an object path {@link #.set} it is also created if it not already exists. Values can be retrieved from the objectpath with {@link #get}.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.base.util.ObjectPath")]
				public partial class ObjectPath
				{
					#region Methods

					/// <summary>
					/// Creates a object path from the provided path in the provided root context.
					/// 
					/// The provided path is used to navigate through the nested objects, starting with the root context.
					/// </summary>
					/// <param name="vObjectPath">Path as string where each name is separated by '.'. Can also be an array of names.</param>
					/// <param name="oRootContext">Root context where the path starts</param>
					/// <returns>The newly created context object, e.g. base.my.test.module</returns>
					public extern static object create(Union<string, string[]> vObjectPath, object oRootContext);

					/// <summary>
					/// Creates a object path from the provided path in the provided root context.
					/// 
					/// The provided path is used to navigate through the nested objects, starting with the root context.
					/// </summary>
					/// <param name="vObjectPath">Path as string where each name is separated by '.'. Can also be an array of names.</param>
					/// <returns>The newly created context object, e.g. base.my.test.module</returns>
					public extern static object create(Union<string, string[]> vObjectPath);

					/// <summary>
					/// Returns a value located in the provided path. If the provided path cannot be resolved completely, <code>undefined</code> is returned.
					/// 
					/// The provided object path is used to navigate through the nested objects, starting with the root context.
					/// </summary>
					/// <param name="vObjectPath">Path as string where each name is separated by '.'. Can also be an array of names.</param>
					/// <param name="oRootContext">Root context where the path starts</param>
					/// <returns>Returns the value located in the provided path, or <code>undefined</code> if the path does not exist completely.</returns>
					public extern static object get(Union<string, string[]> vObjectPath, object oRootContext);

					/// <summary>
					/// Returns a value located in the provided path. If the provided path cannot be resolved completely, <code>undefined</code> is returned.
					/// 
					/// The provided object path is used to navigate through the nested objects, starting with the root context.
					/// </summary>
					/// <param name="vObjectPath">Path as string where each name is separated by '.'. Can also be an array of names.</param>
					/// <returns>Returns the value located in the provided path, or <code>undefined</code> if the path does not exist completely.</returns>
					public extern static object get(Union<string, string[]> vObjectPath);

					/// <summary>
					/// Sets a value located in the provided path.
					/// 
					/// The provided path is used to navigate through the nested objects, starting with the root context.
					/// 
					/// <b>Note:</b> Ensures that the object path exists.
					/// </summary>
					/// <param name="vObjectPath">vObjectPath Path as string where each name is separated by '.'. Can also be an array of names.</param>
					/// <param name="oRootContext">Root context where the path starts</param>
					/// <param name="vValue">The value to be set in the root context's object path</param>
					public extern static void set(Union<string, string[]> vObjectPath, object oRootContext, object vValue);

					#endregion

				}
			}
		}
	}
}
