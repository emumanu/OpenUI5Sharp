using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		public static partial class ui
		{
			public static partial class commons
			{
				/// <summary>
				/// Control to enter or display multible row text.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.TextArea")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.TextArea</code> control.")]
				public partial class TextArea : sap.ui.commons.TextField
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.commons.TextField.Settings
					{
						/// <summary>
						/// Height of text field. When it is set (CSS-size such as % or px), this is the exact size.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Number of Columns. Cols means number of characters per row. This proprty is only used if Width is not used.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> cols;

						/// <summary>
						/// Number of Rows. This proprty is only used if Height is not used.
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> rows;

						/// <summary>
						/// Text wrapping. Possible values are: Soft, Hard, Off.
						/// </summary>
						public Union<sap.ui.core.Wrapping, string, sap.ui.@base.ManagedObject.BindPropertyInfo> wrapping;

						/// <summary>
						/// Position of cursor, e.g., to let the user re-start typing at the same position as before the server roundtrip
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> cursorPos;

						/// <summary>
						/// text which appears, in case quick-help is switched on
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> explanation;

						/// <summary>
						/// ID of label control
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> labeledBy;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new TextArea.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TextArea(string sId, sap.ui.commons.TextArea.Settings mSettings);

					/// <summary>
					/// Constructor for a new TextArea.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern TextArea(string sId);

					/// <summary>
					/// Constructor for a new TextArea.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern TextArea();

					/// <summary>
					/// Constructor for a new TextArea.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern TextArea(sap.ui.commons.TextArea.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Height of text field. When it is set (CSS-size such as % or px), this is the exact size.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// Sets a new value for property {@link #getHeight height}.
					/// 
					/// Height of text field. When it is set (CSS-size such as % or px), this is the exact size.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sHeight">New value for property <code>height</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextArea setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Property cols

					/// <summary>
					/// Gets current value of property {@link #getCols cols}.
					/// 
					/// Number of Columns. Cols means number of characters per row. This proprty is only used if Width is not used.
					/// </summary>
					/// <returns>Value of property <code>cols</code></returns>
					public extern virtual int getCols();

					/// <summary>
					/// Sets a new value for property {@link #getCols cols}.
					/// 
					/// Number of Columns. Cols means number of characters per row. This proprty is only used if Width is not used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iCols">New value for property <code>cols</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextArea setCols(int iCols);

					#endregion

					#region Methods for Property rows

					/// <summary>
					/// Gets current value of property {@link #getRows rows}.
					/// 
					/// Number of Rows. This proprty is only used if Height is not used.
					/// </summary>
					/// <returns>Value of property <code>rows</code></returns>
					public extern virtual int getRows();

					/// <summary>
					/// Sets a new value for property {@link #getRows rows}.
					/// 
					/// Number of Rows. This proprty is only used if Height is not used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iRows">New value for property <code>rows</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextArea setRows(int iRows);

					#endregion

					#region Methods for Property wrapping

					/// <summary>
					/// Gets current value of property {@link #getWrapping wrapping}.
					/// 
					/// Text wrapping. Possible values are: Soft, Hard, Off.
					/// </summary>
					/// <returns>Value of property <code>wrapping</code></returns>
					public extern virtual sap.ui.core.Wrapping getWrapping();

					/// <summary>
					/// Sets a new value for property {@link #getWrapping wrapping}.
					/// 
					/// Text wrapping. Possible values are: Soft, Hard, Off.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sWrapping">New value for property <code>wrapping</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextArea setWrapping(sap.ui.core.Wrapping sWrapping);

					#endregion

					#region Methods for Property cursorPos

					/// <summary>
					/// Gets current value of property {@link #getCursorPos cursorPos}.
					/// 
					/// Position of cursor, e.g., to let the user re-start typing at the same position as before the server roundtrip
					/// </summary>
					/// <returns>Value of property <code>cursorPos</code></returns>
					public extern virtual int getCursorPos();

					/// <summary>
					/// Property setter for the cursor position
					/// </summary>
					/// <param name="iCursorPos">cursor position</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextArea setCursorPos(int iCursorPos);

					#endregion

					#region Methods for Property explanation

					/// <summary>
					/// Gets current value of property {@link #getExplanation explanation}.
					/// 
					/// text which appears, in case quick-help is switched on
					/// </summary>
					/// <returns>Value of property <code>explanation</code></returns>
					public extern virtual string getExplanation();

					/// <summary>
					/// Sets a new value for property {@link #getExplanation explanation}.
					/// 
					/// text which appears, in case quick-help is switched on
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sExplanation">New value for property <code>explanation</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextArea setExplanation(string sExplanation);

					#endregion

					#region Methods for Property labeledBy

					/// <summary>
					/// Gets current value of property {@link #getLabeledBy labeledBy}.
					/// 
					/// ID of label control
					/// </summary>
					/// <returns>Value of property <code>labeledBy</code></returns>
					[Obsolete("Deprecated since 1.5.2. Please use association AriaLabelledBy instead.")]
					public extern virtual string getLabeledBy();

					/// <summary>
					/// Sets a new value for property {@link #getLabeledBy labeledBy}.
					/// 
					/// ID of label control
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sLabeledBy">New value for property <code>labeledBy</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.5.2. Please use association AriaLabelledBy instead.")]
					public extern virtual sap.ui.commons.TextArea setLabeledBy(string sLabeledBy);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TextArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TextArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.TextArea with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.commons.TextField.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.TextArea.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Property setter for MaxLength
					/// </summary>
					/// <param name="iMaxLength">maximal length of text</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.TextArea setMaxLength(int iMaxLength);

					#endregion

					#endregion

				}
			}
		}
	}
}
