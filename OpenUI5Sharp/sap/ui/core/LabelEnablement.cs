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
				/// Helper functionality for enhancement of a <code>Label</code> with common label functionality.
				/// </summary>
				[External]
				[Namespace(false)]
				public static partial class LabelEnablement
				{
					#region Methods

					/// <summary>
					/// This function should be called on a label control to enrich its functionality.
					/// 
					/// <b>Usage:</b> The function can be called with a control prototype: <code> sap.ui.core.LabelEnablement.enrich(my.Label.prototype); </code> Or the function can be called on instance level in the init function of a label control: <code> my.Label.prototype.init: function(){ sap.ui.core.LabelEnablement.enrich(this); } </code>
					/// 
					/// <b>Preconditions:</b> The given control must implement the interface sap.ui.core.Label and have an association 'labelFor' with cardinality 0..1. This function extends existing API functions. Ensure not to override these extensions AFTER calling this function.
					/// 
					/// <b>What does this function do?</b>
					/// 
					/// A mechanism is added that ensures that a bidirectional reference between the label and its labeled control is established: The label references the labeled control via the HTML 'for' attribute (@see sap.ui.core.LabelEnablement#writeLabelForAttribute). If the labeled control supports the aria-labelledby attribute, a reference to the label is added automatically.
					/// 
					/// In addition an alternative to apply a 'for' reference without influencing the labelFor association of the API is applied (e.g. used by Form). For this purpose the functions setAlternativeLabelFor and getLabelForRendering are added.
					/// </summary>
					/// <param name="oControl">the label control which should be enriched with further label functionality.</param>
					public extern static void enrich(sap.ui.core.Control oControl);

					/// <summary>
					/// Returns an array of IDs of the labels referencing the given element.
					/// </summary>
					/// <param name="oElement">The element whose referencing labels should be returned</param>
					/// <returns>an array of ids of the labels referencing the given element</returns>
					public extern static string[] getReferencingLabels(sap.ui.core.Element oElement);

					/// <summary>
					/// Returns <code>true</code> when the given control is required (property 'required') or one of its referencing labels, <code>false</code> otherwise.
					/// </summary>
					/// <param name="oElement">The element which should be checked for its required state</param>
					/// <returns><code>true</code> when the given control is required (property 'required') or one of its referencing labels, <code>false</code> otherwise</returns>
					public extern static bool isRequired(sap.ui.core.Element oElement);

					/// <summary>
					/// Helper function for the <code>Label</code> control to render the HTML 'for' attribute. This function should be called at the desired location in the renderer code of the <code>Label</code> control.
					/// </summary>
					/// <param name="oRenderManager">The RenderManager that can be used for writing to the render-output-buffer.</param>
					/// <param name="oLabel">The <code>Label</code> for which the 'for' HTML attribute should be written to the render-output-buffer.</param>
					public extern static void writeLabelForAttribute(sap.ui.core.RenderManager oRenderManager, sap.ui.core.Label oLabel);

					#endregion

				}
			}
		}
	}
}
