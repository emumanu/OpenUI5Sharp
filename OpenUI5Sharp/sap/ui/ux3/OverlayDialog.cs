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
			public static partial class ux3
			{
				/// <summary>
				/// Dialog implementation based on the Overlay. If used in a Shell it leaves the Tool-Palette, Pane-Bar and Header-Items accessible.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.OverlayDialog")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class OverlayDialog : sap.ui.ux3.Overlay
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.ux3.Overlay.Settings
					{
						/// <summary>
						/// Determines the width of the Overlay Dialog. If the width is set to "auto" it is always 50% of the overlay width.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> width;

						/// <summary>
						/// Determines the height of the Overlay Dialog. If the height is set to "auto" it is always 50% of the overlay height.
						/// </summary>
						public Union<sap.ui.core.CSSSize, string, sap.ui.@base.ManagedObject.BindPropertyInfo> height;

						/// <summary>
						/// Content for the OverlayDialog.
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new OverlayDialog.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
					/// <param name="mSettings">Initial settings for the new control.</param>
					public extern OverlayDialog(string sId, sap.ui.ux3.OverlayDialog.Settings mSettings);

					/// <summary>
					/// Constructor for a new OverlayDialog.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">ID for the new control, generated automatically if no ID is given.</param>
					public extern OverlayDialog(string sId);

					/// <summary>
					/// Constructor for a new OverlayDialog.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern OverlayDialog();

					/// <summary>
					/// Constructor for a new OverlayDialog.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">Initial settings for the new control.</param>
					public extern OverlayDialog(sap.ui.ux3.OverlayDialog.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property width

					/// <summary>
					/// Gets current value of property {@link #getWidth width}.
					/// 
					/// Determines the width of the Overlay Dialog. If the width is set to "auto" it is always 50% of the overlay width.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <returns>Value of property <code>width</code></returns>
					public extern virtual sap.ui.core.CSSSize getWidth();

					/// <summary>
					/// The width for the OverlayDialog.
					/// </summary>
					/// <param name="sWidth"></param>
					public extern virtual void setWidth(sap.ui.core.CSSSize sWidth);

					#endregion

					#region Methods for Property height

					/// <summary>
					/// Gets current value of property {@link #getHeight height}.
					/// 
					/// Determines the height of the Overlay Dialog. If the height is set to "auto" it is always 50% of the overlay height.
					/// 
					/// Default value is <code>auto</code>.
					/// </summary>
					/// <returns>Value of property <code>height</code></returns>
					public extern virtual sap.ui.core.CSSSize getHeight();

					/// <summary>
					/// The height for the OverlayDialog.
					/// </summary>
					/// <param name="sHeight"></param>
					public extern virtual void setHeight(sap.ui.core.CSSSize sHeight);

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// Content for the OverlayDialog.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation {@link #getContent content}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.OverlayDialog destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.OverlayDialog insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content to the aggregation {@link #getContent content}.
					/// </summary>
					/// <param name="oContent">The content to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.OverlayDialog addContent(sap.ui.core.Control oContent);

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

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.OverlayDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.ux3.Overlay.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.OverlayDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.ux3.Overlay.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.OverlayDialog with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.ux3.Overlay.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.OverlayDialog.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					[Name("getMetadata")]
					public extern static sap.ui.@base.Metadata getMetadataStatic();

					/// <summary>
					/// This Method is not supported for the OverlayDialog.
					/// </summary>
					/// <param name="bVisible"></param>
					public extern virtual void setOpenButtonVisible(bool bVisible);

					#endregion

					#endregion

				}
			}
		}
	}
}
