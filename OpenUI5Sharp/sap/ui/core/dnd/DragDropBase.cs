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
				public static partial class dnd
				{
					/// <summary>
					/// Provides the base class for all drag-and-drop configurations. This feature enables a native HTML5 drag-and-drop API for the controls, therefore it is limited to browser support. <h3>Limitations</h3> <ul> <li>There is no mobile device that supports drag and drop.</li> <li>There is no accessible alternative for drag and drop. Applications which use the drag-and-drop functionality must provide an accessible alternative UI (for example, action buttons or menus) to perform the same operations.</li> <li>A custom dragging ghost element is not possible in Internet Explorer.</li> <li>Transparency of the drag ghost element and the cursor during drag-and-drop operations depends on the browser implementation.</li> <li>Internet Explorer does only support plain text MIME type for the DataTransfer Object.</li> <li>Constraining a drag position is not possible, therefore there is no snap-to-grid or snap-to-element feature possible.</li> <li>For controls which do not provide an aggregation <code>dragDropConfig</code> drag and drop might not work correctly if they are configured as target via {@link sap.ui.core.dnd.DragDropInfo}.</li> </ul>
					/// </summary>
					[External]
					[Namespace(false)]
					public abstract partial class DragDropBase : sap.ui.core.Element
					{
						#region Settings

						/// <summary>
						/// Settings class to create the object
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class Settings : sap.ui.core.Element.Settings
						{
							/// <summary>
							/// Defines the name of the group to which this object belongs. If <code>groupName</code> is specified, then this object will only interacts with other drag-and-drop objects within the same group.
							/// </summary>
							public Union<string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> groupName;

							/// <summary>
							/// Indicates whether this configuration is active or not.
							/// </summary>
							public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> enabled;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a new DragDropBase.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern DragDropBase(string sId, sap.ui.core.dnd.DragDropBase.Settings mSettings);

						/// <summary>
						/// Constructor for a new DragDropBase.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
						public extern DragDropBase(string sId);

						/// <summary>
						/// Constructor for a new DragDropBase.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						public extern DragDropBase();

						/// <summary>
						/// Constructor for a new DragDropBase.
						/// 
						/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
						/// </summary>
						/// <param name="mSettings">Initial settings for the new control</param>
						public extern DragDropBase(sap.ui.core.dnd.DragDropBase.Settings mSettings);

						#endregion

						#region Methods

						#region Methods for Property groupName

						/// <summary>
						/// Gets current value of property {@link #getGroupName groupName}.
						/// 
						/// Defines the name of the group to which this object belongs. If <code>groupName</code> is specified, then this object will only interacts with other drag-and-drop objects within the same group.
						/// </summary>
						/// <returns>Value of property <code>groupName</code></returns>
						public extern virtual string getGroupName();

						/// <summary>
						/// Sets a new value for property {@link #getGroupName groupName}.
						/// 
						/// Defines the name of the group to which this object belongs. If <code>groupName</code> is specified, then this object will only interacts with other drag-and-drop objects within the same group.
						/// 
						/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
						/// </summary>
						/// <param name="sGroupName">New value for property <code>groupName</code></param>
						/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
						public extern virtual sap.ui.core.dnd.DragDropBase setGroupName(string sGroupName);

						#endregion

						#region Methods for Property enabled

						/// <summary>
						/// Gets current value of property {@link #getEnabled enabled}.
						/// 
						/// Indicates whether this configuration is active or not.
						/// 
						/// Default value is <code>true</code>.
						/// </summary>
						/// <returns>Value of property <code>enabled</code></returns>
						public extern virtual bool getEnabled();

						#endregion

						#region Other methods

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.dnd.DragDropBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.dnd.DragDropBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.dnd.DragDropBase with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.dnd.DragDropBase.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						public extern static sap.ui.@base.Metadata getMetadata();

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
