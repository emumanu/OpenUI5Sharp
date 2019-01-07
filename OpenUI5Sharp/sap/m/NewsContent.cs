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
			/// This control displays the news content text and subheader in a tile.
			/// </summary>
			[External]
			[Namespace(false)]
			[Name("sap.m.NewsContent")]
			public partial class NewsContent : sap.ui.core.Control
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
					/// Updates the size of the chart. If not set then the default size is applied based on the device tile.
					/// </summary>
					public Union<sap.m.Size, string, sap.ui.@base.ManagedObject.BindPropertyInfo> size;

					/// <summary>
					/// The content text.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> contentText;

					/// <summary>
					/// The subheader.
					/// </summary>
					public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> subheader;

					/// <summary>
					/// The event is triggered when the News Content is pressed.
					/// </summary>
					public sap.ui.@base.EventDelegate press;

				}

				#endregion

				#region Constructor

				/// <summary>
				/// Constructor for a new sap.m.NewsContent control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NewsContent(string sId, sap.m.NewsContent.Settings mSettings);

				/// <summary>
				/// Constructor for a new sap.m.NewsContent control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="sId">ID for the new control, generated automatically if no ID is given</param>
				public extern NewsContent(string sId);

				/// <summary>
				/// Constructor for a new sap.m.NewsContent control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				public extern NewsContent();

				/// <summary>
				/// Constructor for a new sap.m.NewsContent control.
				/// 
				/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
				/// </summary>
				/// <param name="mSettings">Initial settings for the new control</param>
				public extern NewsContent(sap.m.NewsContent.Settings mSettings);

				#endregion

				#region Methods

				#region Methods for Property size

				/// <summary>
				/// Gets current value of property {@link #getSize size}.
				/// 
				/// Updates the size of the chart. If not set then the default size is applied based on the device tile.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <returns>Value of property <code>size</code></returns>
				[Obsolete("Deprecated since 1.38.0. The NewsContent control has now a fixed size, depending on the used media (desktop, tablet or phone).")]
				public extern virtual sap.m.Size getSize();

				/// <summary>
				/// Sets a new value for property {@link #getSize size}.
				/// 
				/// Updates the size of the chart. If not set then the default size is applied based on the device tile.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// 
				/// Default value is <code>Auto</code>.
				/// </summary>
				/// <param name="sSize">New value for property <code>size</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				[Obsolete("Deprecated since 1.38.0. The NewsContent control has now a fixed size, depending on the used media (desktop, tablet or phone).")]
				public extern virtual sap.m.NewsContent setSize(sap.m.Size sSize);

				#endregion

				#region Methods for Property contentText

				/// <summary>
				/// Gets current value of property {@link #getContentText contentText}.
				/// 
				/// The content text.
				/// </summary>
				/// <returns>Value of property <code>contentText</code></returns>
				public extern virtual string getContentText();

				/// <summary>
				/// Sets a new value for property {@link #getContentText contentText}.
				/// 
				/// The content text.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sContentText">New value for property <code>contentText</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NewsContent setContentText(string sContentText);

				#endregion

				#region Methods for Property subheader

				/// <summary>
				/// Gets current value of property {@link #getSubheader subheader}.
				/// 
				/// The subheader.
				/// </summary>
				/// <returns>Value of property <code>subheader</code></returns>
				public extern virtual string getSubheader();

				/// <summary>
				/// Sets a new value for property {@link #getSubheader subheader}.
				/// 
				/// The subheader.
				/// 
				/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
				/// </summary>
				/// <param name="sSubheader">New value for property <code>subheader</code></param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NewsContent setSubheader(string sSubheader);

				#endregion

				#region Methods for Aggregation _contentText

				#endregion

				#region Methods for Event press

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.NewsContent</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NewsContent</code> itself.
				/// 
				/// The event is triggered when the News Content is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.NewsContent</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NewsContent attachPress(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.NewsContent</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NewsContent</code> itself.
				/// 
				/// The event is triggered when the News Content is pressed.
				/// </summary>
				/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NewsContent attachPress(object oData, sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.NewsContent</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NewsContent</code> itself.
				/// 
				/// The event is triggered when the News Content is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NewsContent attachPress(sap.ui.@base.EventDelegate fnFunction);

				/// <summary>
				/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.m.NewsContent</code>.
				/// 
				/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.m.NewsContent</code> itself.
				/// 
				/// The event is triggered when the News Content is pressed.
				/// </summary>
				/// <param name="fnFunction">The function to be called when the event occurs</param>
				/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.m.NewsContent</code> itself</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NewsContent attachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.m.NewsContent</code>.
				/// 
				/// The passed function and listener object must match the ones used for event registration.
				/// </summary>
				/// <param name="fnFunction">The function to be called, when the event occurs</param>
				/// <param name="oListener">Context object on which the given function had to be called</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NewsContent detachPress(sap.ui.@base.EventDelegate fnFunction, object oListener);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <param name="mParameters">Parameters to pass along with the event</param>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NewsContent firePress(object mParameters);

				/// <summary>
				/// Fires event {@link #event:press press} to attached listeners.
				/// </summary>
				/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
				public extern virtual sap.m.NewsContent firePress();

				#endregion

				#region Other methods

				/// <summary>
				/// Creates a new subclass of class sap.m.NewsContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

				/// <summary>
				/// Creates a new subclass of class sap.m.NewsContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <param name="oClassInfo">Object literal with information about the class</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName, object oClassInfo);

				/// <summary>
				/// Creates a new subclass of class sap.m.NewsContent with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
				/// 
				/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
				/// </summary>
				/// <param name="sClassName">Name of the class being created</param>
				/// <returns>Created class / constructor function</returns>
				public extern static object extend(string sClassName);

				/// <summary>
				/// Returns a metadata object for class sap.m.NewsContent.
				/// </summary>
				/// <returns>Metadata object describing this class</returns>
				[Name("getMetadata")]
				public extern static sap.ui.@base.Metadata getMetadataStatic();

				#endregion

				#endregion

			}
		}
	}
}
