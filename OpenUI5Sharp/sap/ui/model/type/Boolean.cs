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
			public static partial class model
			{
				public static partial class type
				{
					/// <summary>
					/// This class represents boolean simple types.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.type.Boolean")]
					public partial class Boolean : sap.ui.model.SimpleType
					{
						#region Constructor

						/// <summary>
						/// Constructor for a Boolean type.
						/// </summary>
						/// <param name="oFormatOptions">formatting options. Boolean doesn't support any specific format options</param>
						/// <param name="oConstraints">value constraints. Boolean doesn't support additional constraints</param>
						public extern Boolean(object oFormatOptions, object oConstraints);

						/// <summary>
						/// Constructor for a Boolean type.
						/// </summary>
						/// <param name="oFormatOptions">formatting options. Boolean doesn't support any specific format options</param>
						public extern Boolean(object oFormatOptions);

						/// <summary>
						/// Constructor for a Boolean type.
						/// </summary>
						public extern Boolean();

						#endregion

						#region Methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Boolean with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Boolean with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.model.type.Boolean with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.model.SimpleType.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.model.type.Boolean.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						#endregion

					}
				}
			}
		}
	}
}
