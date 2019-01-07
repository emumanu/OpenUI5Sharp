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
			/// List item should be used for a label and an input field.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.InputListItem")]
			public partial class InputListItem : sap.m.ListItemBase
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.m.ListItemBase.Settings
				{
					/// <summary>
					/// Label of the list item
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> label;

					/// <summary>
					/// This property specifies the label text directionality with enumerated options. By default, the label inherits text direction from the DOM.
					/// </summary>
					public Union<sap.ui.core.TextDirection, string, sap.ui.@base.ManagedObject.BindPropertyInfo> labelTextDirection;

					/// <summary>
					/// Content controls can be added
					/// </summary>
					public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new InputListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern InputListItem(string sId, sap.m.InputListItem.Settings mSettings);

				/// <summary>
				/// Constructor for a new InputListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">id for the new control, generated automatically if no id is given</param>
				public extern InputListItem(string sId);

				/// <summary>
				/// Constructor for a new InputListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern InputListItem();

				/// <summary>
				/// Constructor for a new InputListItem.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">initial settings for the new control</param>
				public extern InputListItem(sap.m.InputListItem.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property label

				/// <summary>
				/// Gets current value of property {@link #getLabel label}.
				/// 
				/// Label of the list item
				/// </summary>
				/// <returns>Value of property <code>label</code></returns>
				public extern virtual string getLabel();

				/// <summary>
				/// Sets a new value for property {@link #getLabel label}.
				/// 
				/// Label of the list item
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sLabel">New value for property <code>label</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputListItem setLabel(string sLabel);

				#endregion

				#region Methods for Property labelTextDirection

				/// <summary>
				/// Gets current value of property {@link #getLabelTextDirection labelTextDirection}.
				/// 
				/// This property specifies the label text directionality with enumerated options. By default, the label inherits text direction from the DOM.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <returns>Value of property <code>labelTextDirection</code></returns>
				public extern virtual sap.ui.core.TextDirection getLabelTextDirection();

				/// <summary>
				/// Sets a new value for property {@link #getLabelTextDirection labelTextDirection}.
				/// 
				/// This property specifies the label text directionality with enumerated options. By default, the label inherits text direction from the DOM.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Inherit</code>.
				/// </summary>
				/// <param name="sLabelTextDirection">New value for property <code>labelTextDirection</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputListItem setLabelTextDirection(sap.ui.core.TextDirection sLabelTextDirection);

				#endregion

				#region Methods for Aggregation content

				/// <summary>
				/// Gets content of aggregation {@link #getContent content}.
				/// 
				/// Content controls can be added
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control[] getContent();

				/// <summary>
				/// Destroys all the content in the aggregation {@link #getContent content}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputListItem destroyContent();

				/// <summary>
				/// Inserts a content into the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputListItem insertContent(sap.ui.core.Control oContent, int iIndex);

				/// <summary>
				/// Adds some content to the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputListItem addContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes a content from the aggregation {@link #getContent content}.
				/// </summary>
				/// <param name="vContent">The content to remove or its index or id</param>
				/// <returns>The removed content or <code>null</code></returns>
				public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

				/// <summary>
				/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oContent">The content whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfContent(sap.ui.core.Control oContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getContent content}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.ui.core.Control[] removeAllContent();

				/// <summary>
				/// Binds aggregation {@link #getContent content} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputListItem bindContent(sap.ui.@base.ManagedObject.BindAggregationInfo oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getContent content} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.InputListItem unbindContent();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.InputListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.InputListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.InputListItem with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.m.ListItemBase.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.InputListItem.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

				#endregion

			}
		}
	}
}
