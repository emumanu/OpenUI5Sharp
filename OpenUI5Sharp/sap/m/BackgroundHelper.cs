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
			/// Helper for rendering themable background.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.BackgroundHelper")]
			public static partial class BackgroundHelper
			{
				#region Methods

				/// <summary>
				/// Adds CSS classes and styles to the given RenderManager, depending on the given configuration for background color and background image. To be called by control renderers supporting the global themable background image within their root tag, before they call writeClasses() and writeStyles().
				/// </summary>
				/// <param name="rm">The RenderManager</param>
				/// <param name="sBgColor">A configured custom background color for the control, if any</param>
				/// <param name="sBgImgUrl">The configured custom background image for the control, if any</param>
				public extern static void addBackgroundColorStyles(sap.ui.core.RenderManager rm, string sBgColor, sap.ui.core.URI sBgImgUrl);

				/// <summary>
				/// Adds CSS classes and styles to the given RenderManager, depending on the given configuration for background color and background image. To be called by control renderers supporting the global themable background image within their root tag, before they call writeClasses() and writeStyles().
				/// </summary>
				/// <param name="rm">The RenderManager</param>
				/// <param name="sBgColor">A configured custom background color for the control, if any</param>
				public extern static void addBackgroundColorStyles(sap.ui.core.RenderManager rm, string sBgColor);

				/// <summary>
				/// Adds CSS classes and styles to the given RenderManager, depending on the given configuration for background color and background image. To be called by control renderers supporting the global themable background image within their root tag, before they call writeClasses() and writeStyles().
				/// </summary>
				/// <param name="rm">The RenderManager</param>
				public extern static void addBackgroundColorStyles(sap.ui.core.RenderManager rm);

				/// <summary>
				/// Renders an HTML tag into the given RenderManager which carries the background image which is either configured and given or coming from the current theme. Should be called right after the opening root tag has been completed, so this is the first child element inside the control.
				/// </summary>
				/// <param name="rm">The RenderManager</param>
				/// <param name="oControl">Control within which the tag will be rendered; its ID will be used to generate the element ID</param>
				/// <param name="vCssClass">A CSS class or an array of CSS classes to add to the element</param>
				/// <param name="sBgImgUrl">The image of a configured background image; if this is not given, the theme background will be used and also the other settings are ignored.</param>
				/// <param name="bRepeat">Whether the background image should be repeated/tiled (or stretched)</param>
				/// <param name="fOpacity">The background image opacity, if any</param>
				public extern static void renderBackgroundImageTag(sap.ui.core.RenderManager rm, sap.ui.core.Control oControl, Union<string, string[]> vCssClass, sap.ui.core.URI sBgImgUrl, bool bRepeat, float fOpacity);

				/// <summary>
				/// Renders an HTML tag into the given RenderManager which carries the background image which is either configured and given or coming from the current theme. Should be called right after the opening root tag has been completed, so this is the first child element inside the control.
				/// </summary>
				/// <param name="rm">The RenderManager</param>
				/// <param name="oControl">Control within which the tag will be rendered; its ID will be used to generate the element ID</param>
				/// <param name="vCssClass">A CSS class or an array of CSS classes to add to the element</param>
				/// <param name="sBgImgUrl">The image of a configured background image; if this is not given, the theme background will be used and also the other settings are ignored.</param>
				/// <param name="bRepeat">Whether the background image should be repeated/tiled (or stretched)</param>
				public extern static void renderBackgroundImageTag(sap.ui.core.RenderManager rm, sap.ui.core.Control oControl, Union<string, string[]> vCssClass, sap.ui.core.URI sBgImgUrl, bool bRepeat);

				/// <summary>
				/// Renders an HTML tag into the given RenderManager which carries the background image which is either configured and given or coming from the current theme. Should be called right after the opening root tag has been completed, so this is the first child element inside the control.
				/// </summary>
				/// <param name="rm">The RenderManager</param>
				/// <param name="oControl">Control within which the tag will be rendered; its ID will be used to generate the element ID</param>
				/// <param name="vCssClass">A CSS class or an array of CSS classes to add to the element</param>
				/// <param name="sBgImgUrl">The image of a configured background image; if this is not given, the theme background will be used and also the other settings are ignored.</param>
				public extern static void renderBackgroundImageTag(sap.ui.core.RenderManager rm, sap.ui.core.Control oControl, Union<string, string[]> vCssClass, sap.ui.core.URI sBgImgUrl);

				/// <summary>
				/// Renders an HTML tag into the given RenderManager which carries the background image which is either configured and given or coming from the current theme. Should be called right after the opening root tag has been completed, so this is the first child element inside the control.
				/// </summary>
				/// <param name="rm">The RenderManager</param>
				/// <param name="oControl">Control within which the tag will be rendered; its ID will be used to generate the element ID</param>
				/// <param name="vCssClass">A CSS class or an array of CSS classes to add to the element</param>
				public extern static void renderBackgroundImageTag(sap.ui.core.RenderManager rm, sap.ui.core.Control oControl, Union<string, string[]> vCssClass);

				#endregion

			}
		}
	}
}
