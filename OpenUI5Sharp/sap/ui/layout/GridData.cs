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
			public static partial class layout
			{
				/// <summary>
				/// Grid layout data
				/// 
				/// <b>Note:</b> When <code>GridData</code> is used for controls inside a form the property <code>linebreak</code> has to be set to <code>true</code> when the next form element has to be displayed on a new line. This is needed because otherwise the <code>GridData</code> overrides the layout provided by the <code>Form</code>.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.layout.GridData")]
				public partial class GridData : sap.ui.core.LayoutData
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.core.LayoutData.Settings
					{
						/// <summary>
						/// A string type that represents Grid's span values for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 12 that the container has to take, for example: "L2 M4 S6", "M12", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
						/// </summary>
						public Union<sap.ui.layout.GridSpan, string, sap.ui.@base.ManagedObject.BindPropertyInfo> span;

						/// <summary>
						/// Optional. Defines a span value for extra large screens. This value overwrites the value for extra large screens defined in the parameter "span".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> spanXL;

						/// <summary>
						/// Optional. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "span".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> spanL;

						/// <summary>
						/// Optional. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "span".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> spanM;

						/// <summary>
						/// Optional. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "span".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> spanS;

						/// <summary>
						/// A string type that represents Grid's span values for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 12 that the container has to take, for example: "L2 M4 S6", "M12", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
						/// </summary>
						public Union<sap.ui.layout.GridIndent, string, sap.ui.@base.ManagedObject.BindPropertyInfo> indent;

						/// <summary>
						/// Optional. Defines a span value for extra large screens. This value overwrites the value for extra large screens defined in the parameter "indent".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> indentXL;

						/// <summary>
						/// Optional. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "indent".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> indentL;

						/// <summary>
						/// Optional. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "indent".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> indentM;

						/// <summary>
						/// Optional. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "indent".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> indentS;

						/// <summary>
						/// Defines if this Control is visible on XL - extra Large screens.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleXL;

						/// <summary>
						/// Defines if this Control is visible on Large screens.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleL;

						/// <summary>
						/// Defines if this Control is visible on Medium size screens.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleM;

						/// <summary>
						/// Defines if this Control is visible on small screens.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleS;

						/// <summary>
						/// Optional. Moves a cell backwards so many columns as specified.
						/// </summary>
						public Union<sap.ui.layout.GridIndent, string, sap.ui.@base.ManagedObject.BindPropertyInfo> moveBackwards;

						/// <summary>
						/// Optional. Moves a cell forwards so many columns as specified.
						/// </summary>
						public Union<sap.ui.layout.GridIndent, string, sap.ui.@base.ManagedObject.BindPropertyInfo> moveForward;

						/// <summary>
						/// Optional. If this property is set to true, the control on all-size screens causes a line break within the Grid and becomes the first within the next line.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> linebreak;

						/// <summary>
						/// Optional. If this property is set to true, the control on extra large screens causes a line break within the Grid and becomes the first within the next line.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> linebreakXL;

						/// <summary>
						/// Optional. If this property is set to true, the control on large screens causes a line break within the Grid and becomes the first within the next line.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> linebreakL;

						/// <summary>
						/// Optional. If this property is set to true, the control on medium sized screens causes a line break within the Grid and becomes the first within the next line.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> linebreakM;

						/// <summary>
						/// Optional. If this property is set to true, the control on small screens causes a line break within the Grid and becomes the first within the next line.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> linebreakS;

						/// <summary>
						/// Deprecated. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "span".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> spanLarge;

						/// <summary>
						/// Deprecated. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "span".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> spanMedium;

						/// <summary>
						/// Deprecated. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "span".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> spanSmall;

						/// <summary>
						/// Deprecated. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "indent".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> indentLarge;

						/// <summary>
						/// Deprecated. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "indent".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> indentMedium;

						/// <summary>
						/// Deprecated. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "indent".
						/// </summary>
						public Union<int, string, sap.ui.@base.ManagedObject.BindPropertyInfo> indentSmall;

						/// <summary>
						/// Deprecated. Defines if this Control is visible on Large screens.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleOnLarge;

						/// <summary>
						/// Deprecated. Defines if this Control is visible on Medium size screens.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleOnMedium;

						/// <summary>
						/// Deprecated. Defines if this Control is visible on small screens.
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> visibleOnSmall;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new GridData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern GridData(string sId, sap.ui.layout.GridData.Settings mSettings);

					/// <summary>
					/// Constructor for a new GridData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern GridData(string sId);

					/// <summary>
					/// Constructor for a new GridData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern GridData();

					/// <summary>
					/// Constructor for a new GridData.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern GridData(sap.ui.layout.GridData.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property span

					/// <summary>
					/// Gets current value of property {@link #getSpan span}.
					/// 
					/// A string type that represents Grid's span values for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 12 that the container has to take, for example: "L2 M4 S6", "M12", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
					/// </summary>
					/// <returns>Value of property <code>span</code></returns>
					public extern virtual sap.ui.layout.GridSpan getSpan();

					/// <summary>
					/// Sets a new value for property {@link #getSpan span}.
					/// 
					/// A string type that represents Grid's span values for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 12 that the container has to take, for example: "L2 M4 S6", "M12", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sSpan">New value for property <code>span</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setSpan(sap.ui.layout.GridSpan sSpan);

					#endregion

					#region Methods for Property spanXL

					/// <summary>
					/// Gets current value of property {@link #getSpanXL spanXL}.
					/// 
					/// Optional. Defines a span value for extra large screens. This value overwrites the value for extra large screens defined in the parameter "span".
					/// </summary>
					/// <returns>Value of property <code>spanXL</code></returns>
					public extern virtual int getSpanXL();

					/// <summary>
					/// Sets a new value for property {@link #getSpanXL spanXL}.
					/// 
					/// Optional. Defines a span value for extra large screens. This value overwrites the value for extra large screens defined in the parameter "span".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iSpanXL">New value for property <code>spanXL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setSpanXL(int iSpanXL);

					#endregion

					#region Methods for Property spanL

					/// <summary>
					/// Gets current value of property {@link #getSpanL spanL}.
					/// 
					/// Optional. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "span".
					/// </summary>
					/// <returns>Value of property <code>spanL</code></returns>
					public extern virtual int getSpanL();

					/// <summary>
					/// Sets a new value for property {@link #getSpanL spanL}.
					/// 
					/// Optional. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "span".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iSpanL">New value for property <code>spanL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setSpanL(int iSpanL);

					#endregion

					#region Methods for Property spanM

					/// <summary>
					/// Gets current value of property {@link #getSpanM spanM}.
					/// 
					/// Optional. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "span".
					/// </summary>
					/// <returns>Value of property <code>spanM</code></returns>
					public extern virtual int getSpanM();

					/// <summary>
					/// Sets a new value for property {@link #getSpanM spanM}.
					/// 
					/// Optional. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "span".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iSpanM">New value for property <code>spanM</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setSpanM(int iSpanM);

					#endregion

					#region Methods for Property spanS

					/// <summary>
					/// Gets current value of property {@link #getSpanS spanS}.
					/// 
					/// Optional. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "span".
					/// </summary>
					/// <returns>Value of property <code>spanS</code></returns>
					public extern virtual int getSpanS();

					/// <summary>
					/// Sets a new value for property {@link #getSpanS spanS}.
					/// 
					/// Optional. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "span".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iSpanS">New value for property <code>spanS</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setSpanS(int iSpanS);

					#endregion

					#region Methods for Property indent

					/// <summary>
					/// Gets current value of property {@link #getIndent indent}.
					/// 
					/// A string type that represents Grid's span values for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 12 that the container has to take, for example: "L2 M4 S6", "M12", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
					/// </summary>
					/// <returns>Value of property <code>indent</code></returns>
					public extern virtual sap.ui.layout.GridIndent getIndent();

					/// <summary>
					/// Sets a new value for property {@link #getIndent indent}.
					/// 
					/// A string type that represents Grid's span values for large, medium and small screens. Allowed values are separated by space Letters L, M or S followed by number of columns from 1 to 12 that the container has to take, for example: "L2 M4 S6", "M12", "s10" or "l4 m4". Note that the parameters has to be provided in the order large medium small.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sIndent">New value for property <code>indent</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setIndent(sap.ui.layout.GridIndent sIndent);

					#endregion

					#region Methods for Property indentXL

					/// <summary>
					/// Gets current value of property {@link #getIndentXL indentXL}.
					/// 
					/// Optional. Defines a span value for extra large screens. This value overwrites the value for extra large screens defined in the parameter "indent".
					/// </summary>
					/// <returns>Value of property <code>indentXL</code></returns>
					public extern virtual int getIndentXL();

					/// <summary>
					/// Sets a new value for property {@link #getIndentXL indentXL}.
					/// 
					/// Optional. Defines a span value for extra large screens. This value overwrites the value for extra large screens defined in the parameter "indent".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iIndentXL">New value for property <code>indentXL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setIndentXL(int iIndentXL);

					#endregion

					#region Methods for Property indentL

					/// <summary>
					/// Gets current value of property {@link #getIndentL indentL}.
					/// 
					/// Optional. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "indent".
					/// </summary>
					/// <returns>Value of property <code>indentL</code></returns>
					public extern virtual int getIndentL();

					/// <summary>
					/// Sets a new value for property {@link #getIndentL indentL}.
					/// 
					/// Optional. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "indent".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iIndentL">New value for property <code>indentL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setIndentL(int iIndentL);

					#endregion

					#region Methods for Property indentM

					/// <summary>
					/// Gets current value of property {@link #getIndentM indentM}.
					/// 
					/// Optional. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "indent".
					/// </summary>
					/// <returns>Value of property <code>indentM</code></returns>
					public extern virtual int getIndentM();

					/// <summary>
					/// Sets a new value for property {@link #getIndentM indentM}.
					/// 
					/// Optional. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "indent".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iIndentM">New value for property <code>indentM</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setIndentM(int iIndentM);

					#endregion

					#region Methods for Property indentS

					/// <summary>
					/// Gets current value of property {@link #getIndentS indentS}.
					/// 
					/// Optional. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "indent".
					/// </summary>
					/// <returns>Value of property <code>indentS</code></returns>
					public extern virtual int getIndentS();

					/// <summary>
					/// Sets a new value for property {@link #getIndentS indentS}.
					/// 
					/// Optional. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "indent".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iIndentS">New value for property <code>indentS</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setIndentS(int iIndentS);

					#endregion

					#region Methods for Property visibleXL

					/// <summary>
					/// Gets current value of property {@link #getVisibleXL visibleXL}.
					/// 
					/// Defines if this Control is visible on XL - extra Large screens.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleXL</code></returns>
					public extern virtual bool getVisibleXL();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleXL visibleXL}.
					/// 
					/// Defines if this Control is visible on XL - extra Large screens.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisibleXL">New value for property <code>visibleXL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setVisibleXL(bool bVisibleXL);

					#endregion

					#region Methods for Property visibleL

					/// <summary>
					/// Gets current value of property {@link #getVisibleL visibleL}.
					/// 
					/// Defines if this Control is visible on Large screens.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleL</code></returns>
					public extern virtual bool getVisibleL();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleL visibleL}.
					/// 
					/// Defines if this Control is visible on Large screens.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisibleL">New value for property <code>visibleL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setVisibleL(bool bVisibleL);

					#endregion

					#region Methods for Property visibleM

					/// <summary>
					/// Gets current value of property {@link #getVisibleM visibleM}.
					/// 
					/// Defines if this Control is visible on Medium size screens.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleM</code></returns>
					public extern virtual bool getVisibleM();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleM visibleM}.
					/// 
					/// Defines if this Control is visible on Medium size screens.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisibleM">New value for property <code>visibleM</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setVisibleM(bool bVisibleM);

					#endregion

					#region Methods for Property visibleS

					/// <summary>
					/// Gets current value of property {@link #getVisibleS visibleS}.
					/// 
					/// Defines if this Control is visible on small screens.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleS</code></returns>
					public extern virtual bool getVisibleS();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleS visibleS}.
					/// 
					/// Defines if this Control is visible on small screens.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisibleS">New value for property <code>visibleS</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setVisibleS(bool bVisibleS);

					#endregion

					#region Methods for Property moveBackwards

					/// <summary>
					/// Gets current value of property {@link #getMoveBackwards moveBackwards}.
					/// 
					/// Optional. Moves a cell backwards so many columns as specified.
					/// </summary>
					/// <returns>Value of property <code>moveBackwards</code></returns>
					public extern virtual sap.ui.layout.GridIndent getMoveBackwards();

					/// <summary>
					/// Sets a new value for property {@link #getMoveBackwards moveBackwards}.
					/// 
					/// Optional. Moves a cell backwards so many columns as specified.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMoveBackwards">New value for property <code>moveBackwards</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setMoveBackwards(sap.ui.layout.GridIndent sMoveBackwards);

					#endregion

					#region Methods for Property moveForward

					/// <summary>
					/// Gets current value of property {@link #getMoveForward moveForward}.
					/// 
					/// Optional. Moves a cell forwards so many columns as specified.
					/// </summary>
					/// <returns>Value of property <code>moveForward</code></returns>
					public extern virtual sap.ui.layout.GridIndent getMoveForward();

					/// <summary>
					/// Sets a new value for property {@link #getMoveForward moveForward}.
					/// 
					/// Optional. Moves a cell forwards so many columns as specified.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sMoveForward">New value for property <code>moveForward</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setMoveForward(sap.ui.layout.GridIndent sMoveForward);

					#endregion

					#region Methods for Property linebreak

					/// <summary>
					/// Gets current value of property {@link #getLinebreak linebreak}.
					/// 
					/// Optional. If this property is set to true, the control on all-size screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>linebreak</code></returns>
					public extern virtual bool getLinebreak();

					/// <summary>
					/// Sets a new value for property {@link #getLinebreak linebreak}.
					/// 
					/// Optional. If this property is set to true, the control on all-size screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bLinebreak">New value for property <code>linebreak</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setLinebreak(bool bLinebreak);

					#endregion

					#region Methods for Property linebreakXL

					/// <summary>
					/// Gets current value of property {@link #getLinebreakXL linebreakXL}.
					/// 
					/// Optional. If this property is set to true, the control on extra large screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>linebreakXL</code></returns>
					public extern virtual bool getLinebreakXL();

					/// <summary>
					/// Sets a new value for property {@link #getLinebreakXL linebreakXL}.
					/// 
					/// Optional. If this property is set to true, the control on extra large screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bLinebreakXL">New value for property <code>linebreakXL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setLinebreakXL(bool bLinebreakXL);

					#endregion

					#region Methods for Property linebreakL

					/// <summary>
					/// Gets current value of property {@link #getLinebreakL linebreakL}.
					/// 
					/// Optional. If this property is set to true, the control on large screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>linebreakL</code></returns>
					public extern virtual bool getLinebreakL();

					/// <summary>
					/// Sets a new value for property {@link #getLinebreakL linebreakL}.
					/// 
					/// Optional. If this property is set to true, the control on large screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bLinebreakL">New value for property <code>linebreakL</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setLinebreakL(bool bLinebreakL);

					#endregion

					#region Methods for Property linebreakM

					/// <summary>
					/// Gets current value of property {@link #getLinebreakM linebreakM}.
					/// 
					/// Optional. If this property is set to true, the control on medium sized screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>linebreakM</code></returns>
					public extern virtual bool getLinebreakM();

					/// <summary>
					/// Sets a new value for property {@link #getLinebreakM linebreakM}.
					/// 
					/// Optional. If this property is set to true, the control on medium sized screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bLinebreakM">New value for property <code>linebreakM</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setLinebreakM(bool bLinebreakM);

					#endregion

					#region Methods for Property linebreakS

					/// <summary>
					/// Gets current value of property {@link #getLinebreakS linebreakS}.
					/// 
					/// Optional. If this property is set to true, the control on small screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <returns>Value of property <code>linebreakS</code></returns>
					public extern virtual bool getLinebreakS();

					/// <summary>
					/// Sets a new value for property {@link #getLinebreakS linebreakS}.
					/// 
					/// Optional. If this property is set to true, the control on small screens causes a line break within the Grid and becomes the first within the next line.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>false</code>.
					/// </summary>
					/// <param name="bLinebreakS">New value for property <code>linebreakS</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.layout.GridData setLinebreakS(bool bLinebreakS);

					#endregion

					#region Methods for Property spanLarge

					/// <summary>
					/// Gets current value of property {@link #getSpanLarge spanLarge}.
					/// 
					/// Deprecated. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "span".
					/// </summary>
					/// <returns>Value of property <code>spanLarge</code></returns>
					[Obsolete("Deprecated since 1.17.1. Use spanL instead.")]
					public extern virtual int getSpanLarge();

					/// <summary>
					/// Sets a new value for property {@link #getSpanLarge spanLarge}.
					/// 
					/// Deprecated. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "span".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iSpanLarge">New value for property <code>spanLarge</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.17.1. Use spanL instead.")]
					public extern virtual sap.ui.layout.GridData setSpanLarge(int iSpanLarge);

					#endregion

					#region Methods for Property spanMedium

					/// <summary>
					/// Gets current value of property {@link #getSpanMedium spanMedium}.
					/// 
					/// Deprecated. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "span".
					/// </summary>
					/// <returns>Value of property <code>spanMedium</code></returns>
					[Obsolete("Deprecated since 1.17.1. Use spanM instead.")]
					public extern virtual int getSpanMedium();

					/// <summary>
					/// Sets a new value for property {@link #getSpanMedium spanMedium}.
					/// 
					/// Deprecated. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "span".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iSpanMedium">New value for property <code>spanMedium</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.17.1. Use spanM instead.")]
					public extern virtual sap.ui.layout.GridData setSpanMedium(int iSpanMedium);

					#endregion

					#region Methods for Property spanSmall

					/// <summary>
					/// Gets current value of property {@link #getSpanSmall spanSmall}.
					/// 
					/// Deprecated. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "span".
					/// </summary>
					/// <returns>Value of property <code>spanSmall</code></returns>
					[Obsolete("Deprecated since 1.17.1. Use spanS instead.")]
					public extern virtual int getSpanSmall();

					/// <summary>
					/// Sets a new value for property {@link #getSpanSmall spanSmall}.
					/// 
					/// Deprecated. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "span".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iSpanSmall">New value for property <code>spanSmall</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.17.1. Use spanS instead.")]
					public extern virtual sap.ui.layout.GridData setSpanSmall(int iSpanSmall);

					#endregion

					#region Methods for Property indentLarge

					/// <summary>
					/// Gets current value of property {@link #getIndentLarge indentLarge}.
					/// 
					/// Deprecated. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "indent".
					/// </summary>
					/// <returns>Value of property <code>indentLarge</code></returns>
					[Obsolete("Deprecated since 1.17.1. Use indentL instead.")]
					public extern virtual int getIndentLarge();

					/// <summary>
					/// Sets a new value for property {@link #getIndentLarge indentLarge}.
					/// 
					/// Deprecated. Defines a span value for large screens. This value overwrites the value for large screens defined in the parameter "indent".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iIndentLarge">New value for property <code>indentLarge</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.17.1. Use indentL instead.")]
					public extern virtual sap.ui.layout.GridData setIndentLarge(int iIndentLarge);

					#endregion

					#region Methods for Property indentMedium

					/// <summary>
					/// Gets current value of property {@link #getIndentMedium indentMedium}.
					/// 
					/// Deprecated. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "indent".
					/// </summary>
					/// <returns>Value of property <code>indentMedium</code></returns>
					[Obsolete("Deprecated since 1.17.1. Use indentM instead.")]
					public extern virtual int getIndentMedium();

					/// <summary>
					/// Sets a new value for property {@link #getIndentMedium indentMedium}.
					/// 
					/// Deprecated. Defines a span value for medium size screens. This value overwrites the value for medium screens defined in the parameter "indent".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iIndentMedium">New value for property <code>indentMedium</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.17.1. Use indentM instead.")]
					public extern virtual sap.ui.layout.GridData setIndentMedium(int iIndentMedium);

					#endregion

					#region Methods for Property indentSmall

					/// <summary>
					/// Gets current value of property {@link #getIndentSmall indentSmall}.
					/// 
					/// Deprecated. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "indent".
					/// </summary>
					/// <returns>Value of property <code>indentSmall</code></returns>
					[Obsolete("Deprecated since 1.17.1. Use indentS instead.")]
					public extern virtual int getIndentSmall();

					/// <summary>
					/// Sets a new value for property {@link #getIndentSmall indentSmall}.
					/// 
					/// Deprecated. Defines a span value for small screens. This value overwrites the value for small screens defined in the parameter "indent".
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="iIndentSmall">New value for property <code>indentSmall</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.17.1. Use indentS instead.")]
					public extern virtual sap.ui.layout.GridData setIndentSmall(int iIndentSmall);

					#endregion

					#region Methods for Property visibleOnLarge

					/// <summary>
					/// Gets current value of property {@link #getVisibleOnLarge visibleOnLarge}.
					/// 
					/// Deprecated. Defines if this Control is visible on Large screens.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleOnLarge</code></returns>
					[Obsolete("Deprecated since 1.17.1. Use visibleL instead.")]
					public extern virtual bool getVisibleOnLarge();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleOnLarge visibleOnLarge}.
					/// 
					/// Deprecated. Defines if this Control is visible on Large screens.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisibleOnLarge">New value for property <code>visibleOnLarge</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.17.1. Use visibleL instead.")]
					public extern virtual sap.ui.layout.GridData setVisibleOnLarge(bool bVisibleOnLarge);

					#endregion

					#region Methods for Property visibleOnMedium

					/// <summary>
					/// Gets current value of property {@link #getVisibleOnMedium visibleOnMedium}.
					/// 
					/// Deprecated. Defines if this Control is visible on Medium size screens.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleOnMedium</code></returns>
					[Obsolete("Deprecated since 1.17.1. Use visibleM instead.")]
					public extern virtual bool getVisibleOnMedium();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleOnMedium visibleOnMedium}.
					/// 
					/// Deprecated. Defines if this Control is visible on Medium size screens.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisibleOnMedium">New value for property <code>visibleOnMedium</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.17.1. Use visibleM instead.")]
					public extern virtual sap.ui.layout.GridData setVisibleOnMedium(bool bVisibleOnMedium);

					#endregion

					#region Methods for Property visibleOnSmall

					/// <summary>
					/// Gets current value of property {@link #getVisibleOnSmall visibleOnSmall}.
					/// 
					/// Deprecated. Defines if this Control is visible on small screens.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>visibleOnSmall</code></returns>
					[Obsolete("Deprecated since 1.17.1. Use visibleS instead.")]
					public extern virtual bool getVisibleOnSmall();

					/// <summary>
					/// Sets a new value for property {@link #getVisibleOnSmall visibleOnSmall}.
					/// 
					/// Deprecated. Defines if this Control is visible on small screens.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bVisibleOnSmall">New value for property <code>visibleOnSmall</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					[Obsolete("Deprecated since 1.17.1. Use visibleS instead.")]
					public extern virtual sap.ui.layout.GridData setVisibleOnSmall(bool bVisibleOnSmall);

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.GridData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.GridData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.layout.GridData with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.LayoutData.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.layout.GridData.
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
}
