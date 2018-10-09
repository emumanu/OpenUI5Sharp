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
			/// QuickViewGroup consists of a title (optional) and an entity of group elements.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.QuickViewGroup")]
			public partial class QuickViewGroup : sap.ui.core.Element
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
					/// Determines whether the group is visible on the screen.
					/// </summary>
					public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visible;

					/// <summary>
					/// The title of the group
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> heading;

					/// <summary>
					/// A combination of one label and another control (Link or Text) associated to this label.
					/// </summary>
					public Union<sap.m.QuickViewGroupElement[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> elements;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new QuickViewGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewGroup(string sId, sap.m.QuickViewGroup.Settings mSettings);

				/// <summary>
				/// Constructor for a new QuickViewGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern QuickViewGroup(string sId);

				/// <summary>
				/// Constructor for a new QuickViewGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern QuickViewGroup();

				/// <summary>
				/// Constructor for a new QuickViewGroup.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern QuickViewGroup(sap.m.QuickViewGroup.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property visible

				/// <summary>
				/// Gets current value of property {@link #getVisible visible}.
				/// 
				/// Determines whether the group is visible on the screen.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>visible</code></returns>
				public extern virtual bool getVisible();

				/// <summary>
				/// Sets a new value for property {@link #getVisible visible}.
				/// 
				/// Determines whether the group is visible on the screen.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bVisible">New value for property <code>visible</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroup setVisible(bool bVisible);

				#endregion

				#region Methods for Property heading

				/// <summary>
				/// Gets current value of property {@link #getHeading heading}.
				/// 
				/// The title of the group
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <returns>Value of property <code>heading</code></returns>
				public extern virtual string getHeading();

				/// <summary>
				/// Sets a new value for property {@link #getHeading heading}.
				/// 
				/// The title of the group
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>empty string</code>.
				/// </summary>
				/// <param name="sHeading">New value for property <code>heading</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroup setHeading(string sHeading);

				#endregion

				#region Methods for Aggregation elements

				/// <summary>
				/// Gets content of aggregation {@link #getElements elements}.
				/// 
				/// A combination of one label and another control (Link or Text) associated to this label.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.QuickViewGroupElement[] getElements();

				/// <summary>
				/// Destroys all the elements in the aggregation {@link #getElements elements}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroup destroyElements();

				/// <summary>
				/// Inserts a element into the aggregation {@link #getElements elements}.
				/// </summary>
				/// <param name="oElement">The element to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the element should be inserted at; for a negative value of <code>iIndex</code>, the element is inserted at position 0; for a value greater than the current size of the aggregation, the element is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroup insertElement(sap.m.QuickViewGroupElement oElement, int iIndex);

				/// <summary>
				/// Adds some element to the aggregation {@link #getElements elements}.
				/// </summary>
				/// <param name="oElement">The element to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroup addElement(sap.m.QuickViewGroupElement oElement);

				/// <summary>
				/// Removes a element from the aggregation {@link #getElements elements}.
				/// </summary>
				/// <param name="vElement">The element to remove or its index or id</param>
				/// <returns>The removed element or <code>null</code></returns>
				public extern virtual sap.m.QuickViewGroupElement removeElement(Union<int, string, sap.m.QuickViewGroupElement> vElement);

				/// <summary>
				/// Checks for the provided <code>sap.m.QuickViewGroupElement</code> in the aggregation {@link #getElements elements}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oElement">The element whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfElement(sap.m.QuickViewGroupElement oElement);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getElements elements}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.QuickViewGroupElement[] removeAllElements();

				/// <summary>
				/// Binds aggregation {@link #getElements elements} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroup bindElements(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getElements elements} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.QuickViewGroup unbindElements();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.QuickViewGroup with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.QuickViewGroup.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
