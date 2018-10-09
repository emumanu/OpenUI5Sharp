using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public static partial class sap
	{
		/// <summary>
		/// SAP UxAP
		/// </summary>
		[External]
		[Namespace(false)]
		[Name("sap.uxap")]
		public static partial class uxap
		{
			/// <summary>
			/// Used by the <code>ObjectSectionBase</code> control to define the importance of the content contained in it.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.Importance")]
			public enum Importance
			{
				/// <summary>
				/// High importance of the content.
				/// </summary>
				High,
				/// <summary>
				/// Low importance of the content.
				/// </summary>
				Low,
				/// <summary>
				/// Medium importance of the content.
				/// </summary>
				Medium,
			}
			/// <summary>
			/// Interface for controls that are eligible for the <code>headerTitle</code> aggregation of the <code>{@link sap.uxap.ObjectPageLayout}</code>.
			/// 
			/// Controls that implement this interface: <ul> <li><code>{@link sap.uxap.ObjectPageHeader}</code> - <code>ObjectPageLayout</code>'s classic header</code></li> <li><code>{@link sap.uxap.ObjectPageDynamicHeaderTitle}</code> - <code>ObjectPageLayout</code>'s dynamic header</code></li> </ul>
			/// 
			/// For more information on the types of header available for the <code>{@link sap.uxap.ObjectPageLayout ObjectPageLayout}</code>, see {@link topic:d2ef0099542d44dc868719d908e576d0 Object Page Headers}.
			/// 
			/// For details regarding the differences and similarities between the available headers, see {@link topic:9c9d94fd28284539a9a5a57e9caf82a8 Object Page Headers Comparison}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.IHeaderTitle")]
			public partial interface IHeaderTitle
			{
			}
			/// <summary>
			/// Interface for controls that are eligible for the <code>headerContent</code> aggregation of the <code>{@link sap.uxap.ObjectPageLayout}</code>.
			/// 
			/// Controls that implement this interface: <ul> <li><code>{@link sap.uxap.ObjectPageHeaderContent}</code> - <code>ObjectPageLayout</code>'s classic header content</code></li> <li><code>{@link sap.uxap.ObjectPageDynamicHeaderContent}</code> - <code>ObjectPageLayout</code>'s dynamic header content</code></li> </ul>
			/// 
			/// For more information on the types of header available for the <code>{@link sap.uxap.ObjectPageLayout ObjectPageLayout}</code>, see {@link topic:d2ef0099542d44dc868719d908e576d0 Object Page Headers}.
			/// 
			/// For details regarding the differences and similarities between the available headers, see {@link topic:9c9d94fd28284539a9a5a57e9caf82a8 Object Page Headers Comparison}.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.IHeaderContent")]
			public partial interface IHeaderContent
			{
			}
			/// <summary>
			/// Used by the <code>ObjectPageHeader</code> control to define which design to use.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageHeaderDesign")]
			public enum ObjectPageHeaderDesign
			{
				/// <summary>
				/// Dark theme for the <code>ObjectPageHeader</code>.
				/// </summary>
				Dark,
				/// <summary>
				/// Light theme for the <code>ObjectPageHeader</code>.
				/// </summary>
				Light,
			}
			/// <summary>
			/// Used by the <code>BlockBase</code> control to define if it should do automatic adjustment of its nested forms.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.BlockBaseFormAdjustment")]
			public enum BlockBaseFormAdjustment
			{
				/// <summary>
				/// Any form within the block will be automatically adjusted to have as many columns as the colspan of its parent block.
				/// </summary>
				BlockColumns,
				/// <summary>
				/// No automatic adjustment of forms.
				/// </summary>
				None,
				/// <summary>
				/// Any form within the block will be automatically adjusted to have only one column.
				/// </summary>
				OneColumn,
			}
			/// <summary>
			/// Used by the <code>ObjectPageLayout</code> control to define which layout to use (either Collapsed or Expanded).
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageSubSectionMode")]
			public enum ObjectPageSubSectionMode
			{
				/// <summary>
				/// Collapsed mode of display of the <code>ObjectPageLayout</code>.
				/// </summary>
				Collapsed,
				/// <summary>
				/// Expanded mode of displaying the <code>ObjectPageLayout</code>.
				/// </summary>
				Expanded,
			}
			/// <summary>
			/// Used by the <code>ObjectPagSubSection</code> control to define which layout to apply.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageSubSectionLayout")]
			public enum ObjectPageSubSectionLayout
			{
				/// <summary>
				/// Title and actions on the left, inside the block area.
				/// </summary>
				TitleOnLeft,
				/// <summary>
				/// Title and actions on top of the block area.
				/// </summary>
				TitleOnTop,
			}
			/// <summary>
			/// Used by the <code>sap.uxap.component.Component</code> how to initialize the <code>ObjectPageLayout</code> sections and subsections.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageConfigurationMode")]
			public enum ObjectPageConfigurationMode
			{
				/// <summary>
				/// Determines the JSON model.
				/// </summary>
				JsonModel,
				/// <summary>
				/// Determines the JSON URL.
				/// </summary>
				JsonURL,
			}
			/// <summary>
			/// Used by the <code>ObjectPageHeader</code> control to define which shape to use for the image.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.uxap.ObjectPageHeaderPictureShape")]
			public enum ObjectPageHeaderPictureShape
			{
				/// <summary>
				/// Circle shape for the images in the <code>ObjectPageHeader</code>.
				/// </summary>
				Circle,
				/// <summary>
				/// Square shape for the images in the <code>ObjectPageHeader</code>.
				/// </summary>
				Square,
			}
		}
	}
}
