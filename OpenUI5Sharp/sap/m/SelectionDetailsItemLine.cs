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
			/// This Element provides a means to fill an {@link sap.m.SelectionDetailsItem} with content. It is used for a form-like display of a label followed by a value with an optional unit. If the unit is used, the value is displayed bold. <b><i>Note:</i></b>It is protected and should ony be used within the framework itself.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.SelectionDetailsItemLine")]
			public partial class SelectionDetailsItemLine : sap.ui.core.Element
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
					/// The label that is shown as the first part of the line. It may contain the name of the currently selected dimension or measure.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> label;

					/// <summary>
					/// The value of the line, for example the value of the currently selected measure. Expected type is a string or a plain object, including date and time properties of type string.
					/// </summary>
					public Union<object, string, sap.ui.@base.ManagedObject.BindPropertyInfo> value;

					/// <summary>
					/// The display value of the line. If this property is set, it overrides the value property and is displayed as is.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> displayValue;

					/// <summary>
					/// The unit of the given value. If this unit is given, the line is displayed bold.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> unit;

					/// <summary>
					/// A string to be rendered by the control as a line marker. This string must be a valid SVG definition. The only valid tags are: svg, path, line.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> lineMarker;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new SelectionDetailsItemLine.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new element</param>
				public extern SelectionDetailsItemLine(string sId, sap.m.SelectionDetailsItemLine.Settings mSettings);

				/// <summary>
				/// Constructor for a new SelectionDetailsItemLine.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new element, generated automatically if no ID is given</param>
				public extern SelectionDetailsItemLine(string sId);

				/// <summary>
				/// Constructor for a new SelectionDetailsItemLine.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern SelectionDetailsItemLine();

				/// <summary>
				/// Constructor for a new SelectionDetailsItemLine.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new element</param>
				public extern SelectionDetailsItemLine(sap.m.SelectionDetailsItemLine.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property label

				/// <summary>
				/// Gets current value of property {@link #getLabel label}.
				/// 
				/// The label that is shown as the first part of the line. It may contain the name of the currently selected dimension or measure.
				/// </summary>
				/// <returns>Value of property <code>label</code></returns>
				public extern virtual string getLabel();

				/// <summary>
				/// Sets a new value for property {@link #getLabel label}.
				/// 
				/// The label that is shown as the first part of the line. It may contain the name of the currently selected dimension or measure.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sLabel">New value for property <code>label</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItemLine setLabel(string sLabel);

				#endregion

				#region Methods for Property value

				/// <summary>
				/// Gets current value of property {@link #getValue value}.
				/// 
				/// The value of the line, for example the value of the currently selected measure. Expected type is a string or a plain object, including date and time properties of type string.
				/// </summary>
				/// <returns>Value of property <code>value</code></returns>
				public extern virtual object getValue();

				/// <summary>
				/// Sets a new value for property {@link #getValue value}.
				/// 
				/// The value of the line, for example the value of the currently selected measure. Expected type is a string or a plain object, including date and time properties of type string.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="oValue">New value for property <code>value</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItemLine setValue(object oValue);

				#endregion

				#region Methods for Property displayValue

				/// <summary>
				/// Gets current value of property {@link #getDisplayValue displayValue}.
				/// 
				/// The display value of the line. If this property is set, it overrides the value property and is displayed as is.
				/// </summary>
				/// <returns>Value of property <code>displayValue</code></returns>
				public extern virtual string getDisplayValue();

				/// <summary>
				/// Sets a new value for property {@link #getDisplayValue displayValue}.
				/// 
				/// The display value of the line. If this property is set, it overrides the value property and is displayed as is.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDisplayValue">New value for property <code>displayValue</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItemLine setDisplayValue(string sDisplayValue);

				#endregion

				#region Methods for Property unit

				/// <summary>
				/// Gets current value of property {@link #getUnit unit}.
				/// 
				/// The unit of the given value. If this unit is given, the line is displayed bold.
				/// </summary>
				/// <returns>Value of property <code>unit</code></returns>
				public extern virtual string getUnit();

				/// <summary>
				/// Sets a new value for property {@link #getUnit unit}.
				/// 
				/// The unit of the given value. If this unit is given, the line is displayed bold.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sUnit">New value for property <code>unit</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItemLine setUnit(string sUnit);

				#endregion

				#region Methods for Property lineMarker

				/// <summary>
				/// Gets current value of property {@link #getLineMarker lineMarker}.
				/// 
				/// A string to be rendered by the control as a line marker. This string must be a valid SVG definition. The only valid tags are: svg, path, line.
				/// </summary>
				/// <returns>Value of property <code>lineMarker</code></returns>
				public extern virtual string getLineMarker();

				/// <summary>
				/// Sets a new value for property {@link #getLineMarker lineMarker}.
				/// 
				/// A string to be rendered by the control as a line marker. This string must be a valid SVG definition. The only valid tags are: svg, path, line.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sLineMarker">New value for property <code>lineMarker</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.SelectionDetailsItemLine setLineMarker(string sLineMarker);

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectionDetailsItemLine with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectionDetailsItemLine with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.SelectionDetailsItemLine with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Element.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.SelectionDetailsItemLine.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
