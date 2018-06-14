using System;
using Bridge;
using Retyped;
using System.Collections.Generic;

namespace OpenUI5Sharp
{
	public partial class sap
	{
		public static partial class ui
		{
			public static partial class core
			{
				/// <summary>
				/// Base Class for a Renderer.
				/// </summary>
				[External]
				[Namespace(false)]
				public static partial class Renderer
				{
					#region Methods

					/// <summary>
					/// Creates a new static renderer class that extends a given renderer.
					/// 
					/// This method can be used with two signatures that are explained below. In both variants, the returned renderer class inherits all properties (methods, fields) from the given parent renderer class. Both variants also add an 'extend' method to the created renderer class that behaves like the new signature of this <code>Renderer.extend</code> method, but creates subclasses of the new class, not of <code>sap.ui.core.Renderer</code>.
					/// 
					/// <b>New Signature</b><br> In the new signature variant, two parameters must be given: a qualified name for the new renderer (its class name), and an optional object literal that contains methods or fields to be added to the new renderer class.
					/// 
					/// This signature has been designed to resemble the class extension mechanism as provided by {@link sap.ui.base.Object.extend Object.extend}.
					/// 
					/// <pre>
					/// sap.ui.define(['sap/ui/core/Renderer'],
					///     function(Renderer) {
					///     "use strict";
					/// 
					///     var LabelRenderer = Renderer.extend('sap.m.LabelRenderer', {
					///         render: function(oRM, oControl) {
					/// 
					///             renderPreamble(oRM, oControl);
					/// 
					///             // implementation core renderer logic here
					/// 
					///             renderPostamble(oRM, oControl);
					/// 
					///         },
					/// 
					///         renderPreamble : function(oRM, oControl) {
					///         ...
					///         },
					/// 
					///         renderPostamble : function(oRM, oControl) {
					///         ...
					///         }
					/// 
					///     });
					/// 
					///     return LabelRenderer;
					/// });
					/// </pre>
					/// 
					/// The extension of Renderers works across multiple levels. A FancyLabelRenderer can extend the above LabelRenderer:
					/// 
					/// <pre>
					/// sap.ui.define(['sap/m/LabelRenderer'],
					///     function(LabelRenderer) {
					///     "use strict";
					/// 
					///     var FancyLabelRenderer = LabelRenderer.extend('sap.mylib.FancyLabelRenderer', {
					///         render: function(oRM, oControl) {
					/// 
					///             // call base renderer
					///             LabelRenderer.renderPreamble(oRM, oControl);
					/// 
					///             // ... do your own fancy rendering here
					/// 
					///             // call base renderer again
					///             LabelRenderer.renderPostamble(oRM, oControl);
					///         }
					///     });
					/// 
					///     return FancyLabelRenderer;
					/// });
					/// </pre>
					/// 
					/// <b>Note:</b> the new signature no longer requires the <code>bExport</code> flag to be set for the enclosing {@link sap.ui.define} call. The Renderer base class takes care of the necessary global export of the renderer. This allows Non-SAP developers to write a renderer that complies with the documented restriction for <code>sap.ui.define</code> (no use of bExport = true outside sap.ui.core projects).
					/// 
					/// <b>Deprecated Signature</b><br> The deprecated old signature expects just one parameter: a renderer that should be extended. With that signature the renderer can't be exported globally as the name of the renderer class is not known.
					/// 
					/// For compatibility reasons, the class created by the deprecated signature contains a property <code>_super</code> that references the parent class. It shouldn't be used by applications / control developers as it doesn't work reliably for deeper inheritance chains: if the old variant of <code>Renderer.extend</code> is used on two or more levels of the inheritance hierarchy, the <code>_super</code> property of the resulting renderer class will always point to the implementation of the base renderer of the last call to extend. Instead of using <code>this._super</code>, renderer implementations should use the new signature variant and access the base implementation of a method via the AMD reference to the base renderer (as shown in the FancyLabelRenderer example above).
					/// </summary>
					/// <param name="vName">either the name of the new renderer class (new signature) or the base renderer to extend (deprecated signature)</param>
					/// <param name="oRendererInfo">methods and/or properties that should be added to the new renderer class</param>
					/// <returns>a new static renderer class that can be enriched further</returns>
					public extern static object extend(Union<string, object> vName, object oRendererInfo);

					/// <summary>
					/// Creates a new static renderer class that extends a given renderer.
					/// 
					/// This method can be used with two signatures that are explained below. In both variants, the returned renderer class inherits all properties (methods, fields) from the given parent renderer class. Both variants also add an 'extend' method to the created renderer class that behaves like the new signature of this <code>Renderer.extend</code> method, but creates subclasses of the new class, not of <code>sap.ui.core.Renderer</code>.
					/// 
					/// <b>New Signature</b><br> In the new signature variant, two parameters must be given: a qualified name for the new renderer (its class name), and an optional object literal that contains methods or fields to be added to the new renderer class.
					/// 
					/// This signature has been designed to resemble the class extension mechanism as provided by {@link sap.ui.base.Object.extend Object.extend}.
					/// 
					/// <pre>
					/// sap.ui.define(['sap/ui/core/Renderer'],
					///     function(Renderer) {
					///     "use strict";
					/// 
					///     var LabelRenderer = Renderer.extend('sap.m.LabelRenderer', {
					///         render: function(oRM, oControl) {
					/// 
					///             renderPreamble(oRM, oControl);
					/// 
					///             // implementation core renderer logic here
					/// 
					///             renderPostamble(oRM, oControl);
					/// 
					///         },
					/// 
					///         renderPreamble : function(oRM, oControl) {
					///         ...
					///         },
					/// 
					///         renderPostamble : function(oRM, oControl) {
					///         ...
					///         }
					/// 
					///     });
					/// 
					///     return LabelRenderer;
					/// });
					/// </pre>
					/// 
					/// The extension of Renderers works across multiple levels. A FancyLabelRenderer can extend the above LabelRenderer:
					/// 
					/// <pre>
					/// sap.ui.define(['sap/m/LabelRenderer'],
					///     function(LabelRenderer) {
					///     "use strict";
					/// 
					///     var FancyLabelRenderer = LabelRenderer.extend('sap.mylib.FancyLabelRenderer', {
					///         render: function(oRM, oControl) {
					/// 
					///             // call base renderer
					///             LabelRenderer.renderPreamble(oRM, oControl);
					/// 
					///             // ... do your own fancy rendering here
					/// 
					///             // call base renderer again
					///             LabelRenderer.renderPostamble(oRM, oControl);
					///         }
					///     });
					/// 
					///     return FancyLabelRenderer;
					/// });
					/// </pre>
					/// 
					/// <b>Note:</b> the new signature no longer requires the <code>bExport</code> flag to be set for the enclosing {@link sap.ui.define} call. The Renderer base class takes care of the necessary global export of the renderer. This allows Non-SAP developers to write a renderer that complies with the documented restriction for <code>sap.ui.define</code> (no use of bExport = true outside sap.ui.core projects).
					/// 
					/// <b>Deprecated Signature</b><br> The deprecated old signature expects just one parameter: a renderer that should be extended. With that signature the renderer can't be exported globally as the name of the renderer class is not known.
					/// 
					/// For compatibility reasons, the class created by the deprecated signature contains a property <code>_super</code> that references the parent class. It shouldn't be used by applications / control developers as it doesn't work reliably for deeper inheritance chains: if the old variant of <code>Renderer.extend</code> is used on two or more levels of the inheritance hierarchy, the <code>_super</code> property of the resulting renderer class will always point to the implementation of the base renderer of the last call to extend. Instead of using <code>this._super</code>, renderer implementations should use the new signature variant and access the base implementation of a method via the AMD reference to the base renderer (as shown in the FancyLabelRenderer example above).
					/// </summary>
					/// <param name="vName">either the name of the new renderer class (new signature) or the base renderer to extend (deprecated signature)</param>
					/// <returns>a new static renderer class that can be enriched further</returns>
					public extern static object extend(Union<string, object> vName);

					/// <summary>
					/// Returns the TextAlignment for the provided configuration.
					/// </summary>
					/// <param name="oTextAlign">the text alignment of the Control</param>
					/// <param name="oTextDirection">the text direction of the Control</param>
					/// <returns>the actual text alignment that must be set for this environment</returns>
					public extern static string getTextAlign(sap.ui.core.TextAlign oTextAlign, sap.ui.core.TextDirection oTextDirection);

					#endregion

				}
			}
		}
	}
}
