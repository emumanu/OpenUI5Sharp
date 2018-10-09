using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace UI5
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				[External]
				[Namespace(false)]
				[Name("sap.ui.core.ExtensionPoint")]
				public static partial class ExtensionPoint
				{
					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class LoadOptions
					{
						/// <summary>
						/// The view or fragment containing the extension point
						/// </summary>
						public Union<sap.ui.core.mvc.View, sap.ui.core.Fragment> container;

						/// <summary>
						/// The <code>mOptions.name</code> is used to identify the extension point in the customizing
						/// </summary>
						public string name;

						/// <summary>
						/// Optional callback function creating default content, returning an array of controls. It is executed when there's no customizing, if not provided, no default content will be rendered. <code>mOptions.createDefaultContent</code> might also return a Promise, which resolves with an array of controls.
						/// </summary>
						public object createDefaultContent;

					}

					#endregion

					#region Methods

					/// <summary>
					/// Creates 0..n UI5 controls from an <code>ExtensionPoint</code>.
					/// 
					/// One control if the <code>ExtensionPoint</code> is e.g. filled with a <code>View</code>, zero for extension points without configured extension and n controls for multi-root <code>Fragments</code> as extension.
					/// </summary>
					/// <param name="mOptions">an object map (see below)</param>
					/// <returns>a Promise, which resolves with an array of 0..n controls created from an <code>ExtensionPoint</code>. If <code>mOptions.createDefaultContent</code> is called and returns a Promise, that Promise is returned by <code>ExtensionPoint.load</code>.</returns>
					public extern static jquery.JQueryPromise<sap.ui.core.Control[]> load(sap.ui.core.ExtensionPoint.LoadOptions mOptions);

					#endregion

				}
			}
		}
	}
}
