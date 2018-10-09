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
			/// Represents a predefined range of colors for easier selection.
			/// 
			/// <h3>Overview</h3> The <code>ColorPalette</code> provides the users with a range of predefined colors.
			/// 
			/// You can customize them with the use of the <code>colors</code> property. You can specify a <code>defaultColor</code> and display a "Default color" button for the user to choose directly. You can display a "More colors..." button that opens an additional color picker for the user to choose specific colors that are not present in the predefined range.
			/// 
			/// <h3>Usage</h3>
			/// 
			/// The palette is intended for users, who don't want to check and remember the different values of the colors and spend large amount of time to configure the right color through the color picker.
			/// 
			/// The control can be embedded in a form or can be opened as popover (by use of thin wrapper control <code>sap.m.ColorPalettePopover<code>).
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.ColorPalette")]
			public partial class ColorPalette : sap.ui.core.Control
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
					/// Defines the List of colors displayed in the palette. Minimum is 2 colors, maximum is 15 colors.
					/// </summary>
					public Union<sap.ui.core.CSSColor[], string, sap.ui.@base.ManagedObject.BindPropertyInfo> colors;

					/// <summary>
					/// Fired when the user selects a color.
					/// </summary>
					public sap.m.ColorPalette.ColorSelectDelegate colorSelect;

				}

				#endregion

				#region Typed Parameters

				/// <summary>
				/// Parameter to be used as Object Literal
				/// </summary>
				[External]
				[ObjectLiteral]
				public partial class ColorSelectInfo
				{
					/// <summary>
					/// The color that is returned when user chooses the "Default color" button.
					/// </summary>
					public sap.ui.core.CSSColor value;

					/// <summary>
					/// Denotes if the color has been chosen by selecting the "Default Color" button (true or false)
					/// </summary>
					public bool defaultAction;

				}

				#endregion

				#region Delegates

				public delegate void ColorSelectDelegate(sap.ui.@base.Event<sap.m.ColorPalette.ColorSelectInfo> oEvent, object oData);

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new <code>ColorPalette</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ColorPalette(string sId, sap.m.ColorPalette.Settings mSettings);

				/// <summary>
				/// Constructor for a new <code>ColorPalette</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern ColorPalette(string sId);

				/// <summary>
				/// Constructor for a new <code>ColorPalette</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern ColorPalette();

				/// <summary>
				/// Constructor for a new <code>ColorPalette</code>.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern ColorPalette(sap.m.ColorPalette.Settings mSettings);

				#endregion

				#region Methods

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
				public extern virtual sap.m.ColorPalette setColors(sap.ui.core.CSSColor[] sColors);

				#endregion

				#region Methods for Aggregation _defaultColorButton

				#endregion

				#region Methods for Aggregation _moreColorsButton

				#endregion

				#region Methods for Event colorSelect

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalette</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ColorPalette</code> itself.
				/// 
				/// Fired when the user selects a color.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ColorPalette</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalette attachColorSelect(object oData, sap.m.ColorPalette.ColorSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalette</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ColorPalette</code> itself.
				/// 
				/// Fired when the user selects a color.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalette attachColorSelect(object oData, sap.m.ColorPalette.ColorSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalette</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ColorPalette</code> itself.
				/// 
				/// Fired when the user selects a color.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalette attachColorSelect(sap.m.ColorPalette.ColorSelectDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalette</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.ColorPalette</code> itself.
				/// 
				/// Fired when the user selects a color.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.ColorPalette</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalette attachColorSelect(sap.m.ColorPalette.ColorSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:colorSelect colorSelect} event of this <code>sap.m.ColorPalette</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalette detachColorSelect(sap.m.ColorPalette.ColorSelectDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:colorSelect colorSelect} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalette fireColorSelect(sap.m.ColorPalette.ColorSelectInfo mParameters);

				/// <summary>
				/// Fires event {@link #event:colorSelect colorSelect} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.ColorPalette fireColorSelect();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.ColorPalette with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.ColorPalette with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.ColorPalette with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.ColorPalette.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				#endregion

				#endregion

			}
		}
	}
}
