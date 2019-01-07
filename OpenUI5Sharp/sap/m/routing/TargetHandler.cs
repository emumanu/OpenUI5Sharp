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
			public static partial class routing
			{
				[External]
				[Namespace(false)]
				[Name("sap.m.routing.TargetHandler")]
				public partial class TargetHandler : sap.ui.@base.Object
				{
					#region Constructor

					/// <summary>
					/// Instantiates a TargetHandler, a class used for closing dialogs and showing transitions in NavContainers when targets are displayed.<br/> <b>You should not create an own instance of this class.</b> It will be created when using {@link sap.m.routing.Router} or {@link sap.m.routing.Targets}. You may use the {@link #setCloseDialogs} function to specify if dialogs should be closed on displaying other views.
					/// </summary>
					/// <param name="closeDialogs">the default is true - will close all open dialogs before navigating, if set to true. If set to false it will just navigate without closing dialogs.</param>
					public extern TargetHandler(bool closeDialogs);

					#endregion

					#region Methods

					/// <summary>
					/// Creates a new subclass of class sap.m.routing.TargetHandler with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.m.routing.TargetHandler with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.m.routing.TargetHandler with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.Object.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Gets if a navigation should close dialogs
					/// </summary>
					/// <returns>a flag indication if dialogs will be closed</returns>
					public extern virtual bool getCloseDialogs();

					/// <summary>
					/// Returns a metadata object for class sap.m.routing.TargetHandler.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// Sets if a navigation should close dialogs
					/// </summary>
					/// <param name="bCloseDialogs">close dialogs if true</param>
					/// <returns>for chaining</returns>
					public extern virtual sap.m.routing.TargetHandler setCloseDialogs(bool bCloseDialogs);

					#endregion

				}
			}
		}
	}
}
