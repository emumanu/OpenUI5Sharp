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
				/// This feed control flavor represents a lean common feed, or a comment feed, with a text commit function. The control can be used stand alone or in a multiple way, and generally would be integrated directly into a UIArea.
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.Feeder")]
				[Obsolete("Deprecated since 1.38. Instead, use the <code>sap.m.FeedInput</code> control.")]
				public partial class Feeder : sap.ui.core.Control
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
						/// URL to the thumb nail image This property is optional if the feeder is a sub-control of a feed or a feedChunk control. In this case the value of the feed or feddChunk control is used if it's not set. So it must be only set once on the feed or feedChunk control.
						/// </summary>
						public Union<sap.ui.core.URI, string, sap.ui.@base.ManagedObject.BindPropertyInfo> thumbnailSrc;

						/// <summary>
						/// The text for the Feeder. @References are supported.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> text;

						/// <summary>
						/// Type and size of the Feeder
						/// </summary>
						public Union<sap.ui.ux3.FeederType, string, sap.ui.@base.ManagedObject.BindPropertyInfo> type;

						/// <summary>
						/// This property could be used for costum placeholder. If it is not set, the default text is used.
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> placeholderText;

						/// <summary>
						/// Event is fired when the entered text is submitted
						/// </summary>
						public sap.ui.ux3.SubmitDelegate submit;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new Feeder.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Feeder(string sId, sap.ui.ux3.Feeder.Settings mSettings);

					/// <summary>
					/// Constructor for a new Feeder.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern Feeder(string sId);

					/// <summary>
					/// Constructor for a new Feeder.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern Feeder();

					/// <summary>
					/// Constructor for a new Feeder.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern Feeder(sap.ui.ux3.Feeder.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property thumbnailSrc

					/// <summary>
					/// Gets current value of property {@link #getThumbnailSrc thumbnailSrc}.
					/// 
					/// URL to the thumb nail image This property is optional if the feeder is a sub-control of a feed or a feedChunk control. In this case the value of the feed or feddChunk control is used if it's not set. So it must be only set once on the feed or feedChunk control.
					/// </summary>
					/// <returns>Value of property <code>thumbnailSrc</code></returns>
					public extern virtual sap.ui.core.URI getThumbnailSrc();

					/// <summary>
					/// Sets a new value for property {@link #getThumbnailSrc thumbnailSrc}.
					/// 
					/// URL to the thumb nail image This property is optional if the feeder is a sub-control of a feed or a feedChunk control. In this case the value of the feed or feddChunk control is used if it's not set. So it must be only set once on the feed or feedChunk control.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sThumbnailSrc">New value for property <code>thumbnailSrc</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder setThumbnailSrc(sap.ui.core.URI sThumbnailSrc);

					#endregion

					#region Methods for Property text

					/// <summary>
					/// Gets current value of property {@link #getText text}.
					/// 
					/// The text for the Feeder. @References are supported.
					/// </summary>
					/// <returns>Value of property <code>text</code></returns>
					public extern virtual string getText();

					/// <summary>
					/// Sets a new value for property {@link #getText text}.
					/// 
					/// The text for the Feeder. @References are supported.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sText">New value for property <code>text</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder setText(string sText);

					#endregion

					#region Methods for Property type

					/// <summary>
					/// Gets current value of property {@link #getType type}.
					/// 
					/// Type and size of the Feeder
					/// 
					/// Default value is <code>Large</code>.
					/// </summary>
					/// <returns>Value of property <code>type</code></returns>
					public extern virtual sap.ui.ux3.FeederType getType();

					/// <summary>
					/// Sets a new value for property {@link #getType type}.
					/// 
					/// Type and size of the Feeder
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>Large</code>.
					/// </summary>
					/// <param name="sType">New value for property <code>type</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder setType(sap.ui.ux3.FeederType sType);

					#endregion

					#region Methods for Property placeholderText

					/// <summary>
					/// Gets current value of property {@link #getPlaceholderText placeholderText}.
					/// 
					/// This property could be used for costum placeholder. If it is not set, the default text is used.
					/// </summary>
					/// <returns>Value of property <code>placeholderText</code></returns>
					public extern virtual string getPlaceholderText();

					/// <summary>
					/// Sets a new value for property {@link #getPlaceholderText placeholderText}.
					/// 
					/// This property could be used for costum placeholder. If it is not set, the default text is used.
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sPlaceholderText">New value for property <code>placeholderText</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder setPlaceholderText(string sPlaceholderText);

					#endregion

					#region Methods for Event submit

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:submit submit} event of this <code>sap.ui.ux3.Feeder</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feeder</code> itself.
					/// 
					/// Event is fired when the entered text is submitted
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feeder</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder attachSubmit(object oData, sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:submit submit} event of this <code>sap.ui.ux3.Feeder</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feeder</code> itself.
					/// 
					/// Event is fired when the entered text is submitted
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder attachSubmit(object oData, sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:submit submit} event of this <code>sap.ui.ux3.Feeder</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feeder</code> itself.
					/// 
					/// Event is fired when the entered text is submitted
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder attachSubmit(sap.ui.ux3.SubmitDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:submit submit} event of this <code>sap.ui.ux3.Feeder</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.Feeder</code> itself.
					/// 
					/// Event is fired when the entered text is submitted
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.Feeder</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder attachSubmit(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:submit submit} event of this <code>sap.ui.ux3.Feeder</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder detachSubmit(sap.ui.ux3.SubmitDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:submit submit} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder fireSubmit(sap.ui.ux3.SubmitInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:submit submit} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.Feeder fireSubmit();

					#endregion

					#region Other methods

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Feeder with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Feeder with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.Feeder with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.Feeder.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					#endregion

					#endregion

				}
			}
		}
	}
}
