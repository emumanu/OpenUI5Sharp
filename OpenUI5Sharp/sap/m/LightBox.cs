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
			/// Represents a popup containing an image and a footer.
			/// 
			/// <h3>Overview</h3>
			/// 
			/// The purpose of the control is to display an image in its original size as long as this is possible. On smaller screens images are scaled down to fit.
			/// 
			/// <strong>Notes:</strong> <ul> <li>If the image doesn't load in 10 seconds, an error is displayed.</li> <li>Setting the <code>imageContent</code> aggregation of the control as well as the source of the image and the title of the image is <u>mandatory</u>. If the image source is not set, the control will not open.</li> </ul> <h3>Structure</h3>
			/// 
			/// Each LightBox holds a {@link sap.m.LightBoxItem LightBoxItem} which keeps the properties of the image: <ul> <li> imageSrc - The source URI of the image </li> <li> title - The title of the image </li> <li> subtitle - The subtitle of the image </li> <li> alt - The alt text of the image </li> </ul> <h3>Usage</h3>
			/// 
			/// The most common use case is to click on an image thumbnail to view it in bigger size. When the image that should be displayed in the control cannot be loaded, an error is displayed in the popup.
			/// 
			/// <h3>Responsive Behavior</h3>
			/// 
			/// On a mobile device, flipping the device to landscape will flip the lightbox and the image will be adjusted to fit the new dimensions.
			/// 
			/// <h3>Additional Information</h3>
			/// 
			/// Check out the <a href="/#docs/api/symbols/sap.m.LightBox.html" >API Reference</a>.
			/// </summary>
			[External]
			[Namespace(false)]
			public partial class LightBox : sap.ui.core.Control, sap.ui.core.PopupInterface
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
					/// Aggregation which holds data about the image and its description. Although multiple LightBoxItems may be added to this aggregation only the first one in the list will be taken into account.
					/// </summary>
					public Union<sap.m.LightBoxItem[], string, sap.ui.core.Element.BindElementInfo, sap.ui.@base.ManagedObject.BindAggregationInfo> imageContent;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new LightBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern LightBox(string sId, sap.m.LightBox.Settings mSettings);

				/// <summary>
				/// Constructor for a new LightBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern LightBox(string sId);

				/// <summary>
				/// Constructor for a new LightBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern LightBox();

				/// <summary>
				/// Constructor for a new LightBox.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern LightBox(sap.m.LightBox.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Aggregation imageContent

				/// <summary>
				/// Gets content of aggregation {@link #getImageContent imageContent}.
				/// 
				/// Aggregation which holds data about the image and its description. Although multiple LightBoxItems may be added to this aggregation only the first one in the list will be taken into account.
				/// </summary>
				/// <returns></returns>
				public extern virtual sap.m.LightBoxItem[] getImageContent();

				/// <summary>
				/// Destroys all the imageContent in the aggregation {@link #getImageContent imageContent}.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.LightBox destroyImageContent();

				/// <summary>
				/// Inserts a imageContent into the aggregation {@link #getImageContent imageContent}.
				/// </summary>
				/// <param name="oImageContent">The imageContent to insert; if empty, nothing is inserted</param>
				/// <param name="iIndex">The <code>0</code>-based index the imageContent should be inserted at; for a negative value of <code>iIndex</code>, the imageContent is inserted at position 0; for a value greater than the current size of the aggregation, the imageContent is inserted at the last position</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.LightBox insertImageContent(sap.m.LightBoxItem oImageContent, int iIndex);

				/// <summary>
				/// Adds some imageContent to the aggregation {@link #getImageContent imageContent}.
				/// </summary>
				/// <param name="oImageContent">The imageContent to add; if empty, nothing is inserted</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.LightBox addImageContent(sap.m.LightBoxItem oImageContent);

				/// <summary>
				/// Removes a imageContent from the aggregation {@link #getImageContent imageContent}.
				/// </summary>
				/// <param name="vImageContent">The imageContent to remove or its index or id</param>
				/// <returns>The removed imageContent or <code>null</code></returns>
				public extern virtual sap.m.LightBoxItem removeImageContent(Union<int, string, sap.m.LightBoxItem> vImageContent);

				/// <summary>
				/// Checks for the provided <code>sap.m.LightBoxItem</code> in the aggregation {@link #getImageContent imageContent}. and returns its index if found or -1 otherwise.
				/// </summary>
				/// <param name="oImageContent">The imageContent whose index is looked for</param>
				/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
				public extern virtual int indexOfImageContent(sap.m.LightBoxItem oImageContent);

				/// <summary>
				/// Removes all the controls from the aggregation {@link #getImageContent imageContent}.
				/// 
				/// Additionally, it unregisters them from the hosting UIArea.
				/// </summary>
				/// <returns>An array of the removed elements (might be empty)</returns>
				public extern virtual sap.m.LightBoxItem[] removeAllImageContent();

				/// <summary>
				/// Binds aggregation {@link #getImageContent imageContent} to model data.
				/// 
				/// See {@link sap.ui.base.ManagedObject#bindAggregation ManagedObject.bindAggregation} for a detailed description of the possible properties of <code>oBindingInfo</code>.
				/// </summary>
				/// <param name="oBindingInfo">The binding information</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.LightBox bindImageContent(object oBindingInfo);

				/// <summary>
				/// Unbinds aggregation {@link #getImageContent imageContent} from model data.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.LightBox unbindImageContent();

				#endregion

				#region Methods for Aggregation _closeButton

				#endregion

				#region Methods for Aggregation _errorIcon

				#endregion

				#region Methods for Aggregation _errorTitle

				#endregion

				#region Methods for Aggregation _errorSubtitle

				#endregion

				#region Methods for Aggregation _verticalLayout

				#endregion

				#region Methods for Aggregation _invisiblePopupText

				#endregion

				#region Methods for Aggregation _busy

				#endregion

				#region Other methods

				/// <summary>
				/// Closes the LightBox.
				/// </summary>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.LightBox close();

				/// <summary>
				/// Detaches all handlers and destroys the instance.
				/// </summary>
				public extern override void exit();

				/// <summary>
				/// Creates a new subclass of class sap.m.LightBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.LightBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.LightBox with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.LightBox.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				public extern static sap.ui.@base.Metadata getMetadata();

				/// <summary>
				/// Sets up the initial values of the control.
				/// </summary>
				public extern override void init();

				/// <summary>
				/// Rerenders the LightBox.
				/// </summary>
				/// <param name="oOrigin">Origin of the invalidation.</param>
				/// <returns>this LightBox reference for chaining.</returns>
				public extern virtual sap.m.LightBox invalidate(object oOrigin);

				/// <summary>
				/// Returns if the LightBox is open.
				/// </summary>
				/// <returns>Is the LightBox open</returns>
				public extern virtual bool isOpen();

				/// <summary>
				/// Overwrites the onAfterRendering.
				/// </summary>
				public extern override void onAfterRendering();

				/// <summary>
				/// Overwrites the onBeforeRendering.
				/// </summary>
				public extern override void onBeforeRendering();

				/// <summary>
				/// Opens the LightBox.
				/// </summary>
				/// <returns>Pointer to the control instance for chaining.</returns>
				public extern virtual sap.m.LightBox open();

				#endregion

				#endregion

			}
		}
	}
}
