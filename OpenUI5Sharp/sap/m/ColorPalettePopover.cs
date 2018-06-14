using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public static partial class sap
	{
		public static partial class m
		{
			/// <summary>
			/// A thin wrapper over {@link sap.m.ColorPalette} allowing the latter to be used in a popover.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class ColorPalettePopover : sap.ui.core.Control
			{
				#region Settings

				/// <summary>
				/// Settings class to create the object
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class Settings : sap.ui.core.Control.Settings
				{
					/// <summary>
					/// The color, which the app developer will receive when end-user chooses the "Default color" button. See event {@link #event:colorSelect colorSelect}.
					/// </summary>
					public Union<sap.ui.core.CSSColor, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> defaultColor;

					/// <summary>
					/// Defines the List of colors displayed in the palette. Minimum is 2 colors, maximum is 15 colors.
					/// </summary>
					public Union<sap.ui.core.CSSColor[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> colors;

					/// <summary>
					/// Indicates if the button for default color selection is available.
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showDefaultColorButton;

					/// <summary>
					/// Denotes if the color has been chosen by selecting the "Default Color" button (true or false)
					/// </summary>
					public Union<bool, string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> showMoreColorsButton;

					/// <summary>
					/// Fired when the user selects a color.
					/// </summary>
					public sap.m.ColorPalette.ColorSelectDelegate colorSelect;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ColorPalettePopover</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ColorPalettePopover(string sId, sap.m.ColorPalettePopover.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ColorPalettePopover</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ColorPalettePopover(string sId);

				/// <summary>
				/// Constructor for a new <code>ColorPalettePopover</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ColorPalettePopover();

				/// <summary>
				/// Constructor for a new <code>ColorPalettePopover</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ColorPalettePopover(sap.m.ColorPalettePopover.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property defaultColor

				/// <summary>
				/// Gets current value of property {@link #getDefaultColor defaultColor}.
				/// 
				/// The color, which the app developer will receive when end-user chooses the "Default color" button. See event {@link #event:colorSelect colorSelect}.
				/// </summary>
				/// <returns>Value of property <code>defaultColor</code></returns>
				public extern virtual sap.ui.core.CSSColor getDefaultColor();

				/// <summary>
				/// Sets a new value for property {@link #getDefaultColor defaultColor}.
				/// 
				/// The color, which the app developer will receive when end-user chooses the "Default color" button. See event {@link #event:colorSelect colorSelect}.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sDefaultColor">New value for property <code>defaultColor</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover setDefaultColor(sap.ui.core.CSSColor sDefaultColor);

				#endregion

				#region Methods for Property colors

				/// <summary>
				/// Gets current value of property {@link #getColors colors}.
				/// 
				/// Defines the List of colors displayed in the palette. Minimum is 2 colors, maximum is 15 colors.
				/// 
				/// Default value is <code>gold,darkorange,indianred,darkmagenta,cornflowerblue,deepskyblue,darkcyan,olivedrab,darkslategray,azure,white,lightgray,darkgray,dimgray,black</code>.
				/// </summary>
				/// <returns>Value of property <code>colors</code></returns>
				public extern virtual sap.ui.core.CSSColor[] getColors();

				/// <summary>
				/// Sets a new value for property {@link #getColors colors}.
				/// 
				/// Defines the List of colors displayed in the palette. Minimum is 2 colors, maximum is 15 colors.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>gold,darkorange,indianred,darkmagenta,cornflowerblue,deepskyblue,darkcyan,olivedrab,darkslategray,azure,white,lightgray,darkgray,dimgray,black</code>.
				/// </summary>
				/// <param name="sColors">New value for property <code>colors</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover setColors(sap.ui.core.CSSColor[] sColors);

				#endregion

				#region Methods for Property showDefaultColorButton

				/// <summary>
				/// Gets current value of property {@link #getShowDefaultColorButton showDefaultColorButton}.
				/// 
				/// Indicates if the button for default color selection is available.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showDefaultColorButton</code></returns>
				public extern virtual bool getShowDefaultColorButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowDefaultColorButton showDefaultColorButton}.
				/// 
				/// Indicates if the button for default color selection is available.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowDefaultColorButton">New value for property <code>showDefaultColorButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover setShowDefaultColorButton(bool bShowDefaultColorButton);

				#endregion

				#region Methods for Property showMoreColorsButton

				/// <summary>
				/// Gets current value of property {@link #getShowMoreColorsButton showMoreColorsButton}.
				/// 
				/// Denotes if the color has been chosen by selecting the "Default Color" button (true or false)
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <returns>Value of property <code>showMoreColorsButton</code></returns>
				public extern virtual bool getShowMoreColorsButton();

				/// <summary>
				/// Sets a new value for property {@link #getShowMoreColorsButton showMoreColorsButton}.
				/// 
				/// Denotes if the color has been chosen by selecting the "Default Color" button (true or false)
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>true</code>.
				/// </summary>
				/// <param name="bShowMoreColorsButton">New value for property <code>showMoreColorsButton</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover setShowMoreColorsButton(bool bShowMoreColorsButton);

				#endregion

				#region Methods for Event colorSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalettePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ColorPalettePopover</code> itself.
				/// 
				/// Fired when the user selects a color.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ColorPalettePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover attachColorSelect(object oData, sap.m.ColorPalette.ColorSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalettePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ColorPalettePopover</code> itself.
				/// 
				/// Fired when the user selects a color.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover attachColorSelect(object oData, sap.m.ColorPalette.ColorSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalettePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ColorPalettePopover</code> itself.
				/// 
				/// Fired when the user selects a color.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover attachColorSelect(sap.m.ColorPalette.ColorSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalettePopover</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ColorPalettePopover</code> itself.
				/// 
				/// Fired when the user selects a color.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ColorPalettePopover</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover attachColorSelect(sap.m.ColorPalette.ColorSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalettePopover</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover detachColorSelect(sap.m.ColorPalette.ColorSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:colorSelect colorSelect} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover fireColorSelect(sap.m.ColorPalette.ColorSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:colorSelect colorSelect} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalettePopover fireColorSelect();

				#endregion

				#region Other methods

				/// <summary>
				/// Closes the <code>ColorPalettePopover</code>.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.ui.core.Control close();

				/// <summary>
				/// Creates a new subclass of class sap.m.ColorPalettePopover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ColorPalettePopover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ColorPalettePopover with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ColorPalettePopover.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Opens the <code>ColorPalettePopover</code>. The popover is positioned relative to the control parameter on tablet or desktop and is full screen on phone. Therefore the control parameter is only used on tablet or desktop and is ignored on phone.
				/// </summary>
				/// <param name="openBy">When this control is displayed on tablet or desktop, the <code>ColorPalettePopover</code> is positioned relative to this control</param>
				/// <returns>Reference to the opening control</returns>
				public extern virtual object openBy(object openBy);

				#endregion

				#endregion

			}
		}
	}
}
