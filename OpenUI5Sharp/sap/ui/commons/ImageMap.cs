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
			public static partial class commons
			{
				/// <summary>
				/// Combination of image areas where at runtime these areas are starting points for hyperlinks or actions
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.commons.ImageMap")]
				[Obsolete("Deprecated since 1.38. There's not replacement because of the archaic design pattern.")]
				public partial class ImageMap : sap.ui.core.Control
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
						/// Name for the image that serves as reference
						/// </summary>
						public Union<string, sap.ui.@base.ManagedObject.BindPropertyInfo> name;

						/// <summary>
						/// Area representing the reference to the target location
						/// </summary>
						public Union<sap.ui.commons.Area[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> areas;

						/// <summary>
						/// Event for the areas that can be clicked in an ImageMap
						/// </summary>
						public sap.ui.commons.ImageMap.PressDelegate press;

					}

					#endregion

					#region Typed Parameters

					/// <summary>
					/// Parameter to be used as Object Literal
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class PressInfo
					{
						/// <summary>
						/// Id of clicked Area.
						/// </summary>
						public string areaId;

					}

					#endregion

					#region Delegates

					public delegate void PressDelegate(sap.ui.@base.Event<sap.ui.commons.ImageMap.PressInfo> oEvent, object oData);

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new ImageMap.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ImageMap(string sId, sap.ui.commons.ImageMap.Settings mSettings);

					/// <summary>
					/// Constructor for a new ImageMap.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern ImageMap(string sId);

					/// <summary>
					/// Constructor for a new ImageMap.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern ImageMap();

					/// <summary>
					/// Constructor for a new ImageMap.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern ImageMap(sap.ui.commons.ImageMap.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property name

					/// <summary>
					/// Gets current value of property {@link #getName name}.
					/// 
					/// Name for the image that serves as reference
					/// </summary>
					/// <returns>Value of property <code>name</code></returns>
					public extern virtual string getName();

					/// <summary>
					/// Sets a new value for property {@link #getName name}.
					/// 
					/// Name for the image that serves as reference
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// </summary>
					/// <param name="sName">New value for property <code>name</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap setName(string sName);

					#endregion

					#region Methods for Aggregation areas

					/// <summary>
					/// Gets content of aggregation {@link #getAreas areas}.
					/// 
					/// Area representing the reference to the target location
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.commons.Area[] getAreas();

					/// <summary>
					/// Destroys all the areas in the aggregation {@link #getAreas areas}.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap destroyAreas();

					/// <summary>
					/// Inserts a area into the aggregation {@link #getAreas areas}.
					/// </summary>
					/// <param name="oArea">The area to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">The <code>0</code>-based index the area should be inserted at; for a negative value of <code>iIndex</code>, the area is inserted at position 0; for a value greater than the current size of the aggregation, the area is inserted at the last position</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap insertArea(sap.ui.commons.Area oArea, int iIndex);

					/// <summary>
					/// Adds some area to the aggregation {@link #getAreas areas}.
					/// </summary>
					/// <param name="oArea">The area to add; if empty, nothing is inserted</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap addArea(sap.ui.commons.Area oArea);

					/// <summary>
					/// Removes a area from the aggregation {@link #getAreas areas}.
					/// </summary>
					/// <param name="vArea">The area to remove or its index or id</param>
					/// <returns>The removed area or <code>null</code></returns>
					public extern virtual sap.ui.commons.Area removeArea(Union<int, string, sap.ui.commons.Area> vArea);

					/// <summary>
					/// Checks for the provided <code>sap.ui.commons.Area</code> in the aggregation {@link #getAreas areas}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oArea">The area whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfArea(sap.ui.commons.Area oArea);

					/// <summary>
					/// Removes all the controls from the aggregation {@link #getAreas areas}.
					/// 
					/// Additionally, it unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>An array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.commons.Area[] removeAllAreas();

					#endregion

					#region Methods for Event press

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.commons.ImageMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ImageMap</code> itself.
					/// 
					/// Event for the areas that can be clicked in an ImageMap
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ImageMap</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap attachPress(object oData, sap.ui.commons.ImageMap.PressDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.commons.ImageMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ImageMap</code> itself.
					/// 
					/// Event for the areas that can be clicked in an ImageMap
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap attachPress(object oData, sap.ui.commons.ImageMap.PressDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.commons.ImageMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ImageMap</code> itself.
					/// 
					/// Event for the areas that can be clicked in an ImageMap
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap attachPress(sap.ui.commons.ImageMap.PressDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:press press} event of this <code>sap.ui.commons.ImageMap</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.commons.ImageMap</code> itself.
					/// 
					/// Event for the areas that can be clicked in an ImageMap
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.commons.ImageMap</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap attachPress(sap.ui.commons.ImageMap.PressDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:press press} event of this <code>sap.ui.commons.ImageMap</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap detachPress(sap.ui.commons.ImageMap.PressDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:press press} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap firePress(sap.ui.commons.ImageMap.PressInfo mParameters);

					/// <summary>
					/// Fires event {@link #event:press press} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap firePress();

					#endregion

					#region Other methods

					/// <summary>
					/// Adds areas to the Image Map.
					/// 
					/// Each argument must be either a JSon object or a list of objects or the area element or elements.
					/// </summary>
					/// <param name="content">Area content to add</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.commons.ImageMap createArea(object content);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ImageMap with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ImageMap with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.commons.ImageMap with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Returns a metadata object for class sap.ui.commons.ImageMap.
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
