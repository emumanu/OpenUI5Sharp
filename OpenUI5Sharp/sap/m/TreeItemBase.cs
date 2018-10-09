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
			/// The <code>sap.m.TreeItemBase</code> contains the basic features of all specific tree items.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.TreeItemBase")]
			public partial class TreeItemBase : sap.m.ListItemBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ListItemBase.Settings
				{
				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new TreeItemBase.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TreeItemBase(string sId, sap.m.TreeItemBase.Settings mSettings);

				/// <summary>
				/// Constructor for a new TreeItemBase.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no id is given</param>
				public extern TreeItemBase(string sId);

				/// <summary>
				/// Constructor for a new TreeItemBase.
				/// </summary>
				public extern TreeItemBase();

				/// <summary>
				/// Constructor for a new TreeItemBase.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern TreeItemBase(sap.m.TreeItemBase.Settings mSettings);

				#endregion

				#region Methods

				/// <summary>
				/// Creates a new subclass of class sap.m.TreeItemBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.TreeItemBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.TreeItemBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Gets the expanding information of the node.
				/// </summary>
				/// <returns></returns>
				public extern virtual bool getExpanded();

				/// <summary>
				/// Gets the context of the node.
				/// </summary>
				/// <returns></returns>
				public extern virtual object getItemNodeContext();

				/// <summary>
				/// Gets the node level in the hierarchy.
				/// </summary>
				/// <returns></returns>
				public extern virtual int getLevel();

				/// <summary>
				/// Returns a metadata object for class sap.m.TreeItemBase.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Gets the parent node control.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.TreeItemBase getParentNode();

				/// <summary>
				/// Gets the context of the parent node control.
				/// </summary>
				/// <returns></returns>
				public extern virtual object getParentNodeContext();

				/// <summary>
				/// Determines if the node is a leaf.
				/// </summary>
				/// <returns></returns>
				public extern virtual bool isLeaf();

				/// <summary>
				/// Checks if the node is the top level node.
				/// </summary>
				/// <returns></returns>
				public extern virtual bool isTopLevel();

				#endregion

			}
		}
	}
}
