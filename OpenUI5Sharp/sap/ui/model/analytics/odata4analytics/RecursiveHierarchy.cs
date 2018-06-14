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
			public static partial class model
			{
				public static partial class analytics
				{
					public static partial class odata4analytics
					{
						/// <summary>
						/// Representation of a recursive hierarchy.
						/// </summary>
						[External]
						[Namespace(false)]
						public partial class RecursiveHierarchy
						{
							#region Constructor

							/// <summary>
							/// Create a representation of a recursive hierarchy defined on one multiple properties in an OData entity type query. Do not create your own instances.
							/// </summary>
							/// <param name="oEntityType">object for the entity type</param>
							/// <param name="oNodeIDProperty">datajs object for the property holding the hierarchy node ID identifying the hierarchy node to which the OData entry belongs</param>
							/// <param name="oParentNodeIDProperty">datajs object for the property holding the node ID of the parent of the hierarchy node pointed to by the value of oNodeIDProperty</param>
							/// <param name="oNodeLevelProperty">datajs object for the property holding the level number for the of the hierarchy node pointed to by the value of oNodeIDProperty</param>
							/// <param name="oNodeValueProperty">datajs object for the property holding the data value for the of the hierarchy node pointed to by the value of oNodeIDProperty</param>
							/// <param name="oNodeExternalKeyProperty">datajs object for the property holding the node external key of the hierarchy node. The external key is a human-readable identification of a node. The value of the <code>hierarchy-node-external-key-for</code> attribute is always the name of another property in the same type. It points to the related property holding the hierarchy node ID.</param>
							public extern RecursiveHierarchy(sap.ui.model.analytics.odata4analytics.EntityType oEntityType, object oNodeIDProperty, object oParentNodeIDProperty, object oNodeLevelProperty, object oNodeValueProperty, object oNodeExternalKeyProperty);

							#endregion

							#region Methods

							/// <summary>
							/// Get the property holding the node external key of the hierarchy node
							/// </summary>
							/// <returns>The datajs object representing this property</returns>
							public extern virtual object getNodeExternalKeyProperty();

							/// <summary>
							/// Get the property holding the node ID of the hierarchy node
							/// </summary>
							/// <returns>The datajs object representing this property</returns>
							public extern virtual object getNodeIDProperty();

							/// <summary>
							/// Get the property holding the level of the hierarchy node
							/// </summary>
							/// <returns>The datajs object representing this property</returns>
							public extern virtual object getNodeLevelProperty();

							/// <summary>
							/// Get the property holding the value that is structurally organized by the hierarchy
							/// </summary>
							/// <returns>The datajs object representing this property</returns>
							public extern virtual object getNodeValueProperty();

							/// <summary>
							/// Get the property holding the parent node ID of the hierarchy node
							/// </summary>
							/// <returns>The datajs object representing this property</returns>
							public extern virtual object getParentNodeIDProperty();

							/// <summary>
							/// Get indicator if this is a leveled hierarchy
							/// </summary>
							/// <returns>False</returns>
							public extern virtual bool isLeveledHierarchy();

							/// <summary>
							/// Get indicator if this is a recursive hierarchy
							/// </summary>
							/// <returns>True</returns>
							public extern virtual bool isRecursiveHierarchy();

							#endregion

						}
					}
				}
			}
		}
	}
}
