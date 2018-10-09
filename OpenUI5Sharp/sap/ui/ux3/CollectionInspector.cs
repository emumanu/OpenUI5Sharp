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
				/// CollectionInspector
				/// </summary>
				[External]
				[Namespace(false)]
				[Name("sap.ui.ux3.CollectionInspector")]
				[Obsolete("Deprecated since 1.38.")]
				public partial class CollectionInspector : sap.ui.core.Control
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
						/// Defines if the list of collection items is visible on the left
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> sidebarVisible;

						/// <summary>
						/// If set to true, control will fit parents content area
						/// </summary>
						public Union<bool, string, sap.ui.@base.ManagedObject.BindPropertyInfo> fitParent;

						/// <summary>
						/// Collections which are displayed in the COllectionInspector
						/// </summary>
						public Union<sap.ui.ux3.Collection[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> collections;

						/// <summary>
						/// All controls that are currently displayed
						/// </summary>
						public Union<sap.ui.core.Control[], string, sap.ui.@base.ManagedObject.BindAggregationInfo> content;

						/// <summary>
						/// Collection which is currently selected
						/// </summary>
						public Union<sap.ui.ux3.Collection, sap.ui.core.ID, string, sap.ui.@base.ManagedObject.BindPropertyInfo> selectedCollection;

						/// <summary>
						/// Event is fired if user selects a collection
						/// </summary>
						public sap.ui.@base.EventDelegate collectionSelected;

						/// <summary>
						/// Fires when an item in a collection is selected
						/// </summary>
						public sap.ui.@base.EventDelegate itemSelectionChanged;

						/// <summary>
						/// Fires when the edit button is clicked
						/// </summary>
						public sap.ui.@base.EventDelegate editCollection;

					}

					#endregion

					#region Constructor

					/// <summary>
					/// Constructor for a new CollectionInspector.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CollectionInspector(string sId, sap.ui.ux3.CollectionInspector.Settings mSettings);

					/// <summary>
					/// Constructor for a new CollectionInspector.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="sId">id for the new control, generated automatically if no id is given</param>
					public extern CollectionInspector(string sId);

					/// <summary>
					/// Constructor for a new CollectionInspector.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					public extern CollectionInspector();

					/// <summary>
					/// Constructor for a new CollectionInspector.
					/// 
					/// Accepts an object literal <code>mSettings</code> that defines initial property values, aggregated and associated objects as well as event handlers. See {@link sap.ui.base.ManagedObject#constructor} for a general description of the syntax of the settings object.
					/// </summary>
					/// <param name="mSettings">initial settings for the new control</param>
					public extern CollectionInspector(sap.ui.ux3.CollectionInspector.Settings mSettings);

					#endregion

					#region Methods

					#region Methods for Property sidebarVisible

					/// <summary>
					/// Gets current value of property {@link #getSidebarVisible sidebarVisible}.
					/// 
					/// Defines if the list of collection items is visible on the left
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>sidebarVisible</code></returns>
					public extern virtual bool getSidebarVisible();

					/// <summary>
					/// Sets a new value for property {@link #getSidebarVisible sidebarVisible}.
					/// 
					/// Defines if the list of collection items is visible on the left
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bSidebarVisible">New value for property <code>sidebarVisible</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector setSidebarVisible(bool bSidebarVisible);

					#endregion

					#region Methods for Property fitParent

					/// <summary>
					/// Gets current value of property {@link #getFitParent fitParent}.
					/// 
					/// If set to true, control will fit parents content area
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <returns>Value of property <code>fitParent</code></returns>
					public extern virtual bool getFitParent();

					/// <summary>
					/// Sets a new value for property {@link #getFitParent fitParent}.
					/// 
					/// If set to true, control will fit parents content area
					/// 
					/// When called with a value of <code>null</code> or <code>undefined</code>, the default value of the property will be restored.
					/// 
					/// Default value is <code>true</code>.
					/// </summary>
					/// <param name="bFitParent">New value for property <code>fitParent</code></param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector setFitParent(bool bFitParent);

					#endregion

					#region Methods for Aggregation collections

					/// <summary>
					/// Gets content of aggregation {@link #getCollections collections}.
					/// 
					/// Collections which are displayed in the COllectionInspector
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.ux3.Collection[] getCollections();

					/// <summary>
					/// Destroys the collection aggregation
					/// </summary>
					/// <returns>this to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector destroyCollections();

					/// <summary>
					/// Inserts a collection into the aggregation named <code>collections</code>.
					/// </summary>
					/// <param name="oCollection">the collection to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">the <code>0</code>-based index the collection should be inserted at; for a negative value of <code>iIndex</code>, the collection is inserted at position 0; for a value greater than the current size of the aggregation, the collection is inserted at the last position</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector insertCollection(sap.ui.ux3.Collection oCollection, int iIndex);

					/// <summary>
					/// Adds some collection <code>oCollection</code> to the aggregation named <code>collections</code>.
					/// </summary>
					/// <param name="oCollection">the collection to add; if empty, nothing is inserted</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector addCollection(sap.ui.ux3.Collection oCollection);

					/// <summary>
					/// Removes a collection from the aggregation named <code>collections</code>.
					/// </summary>
					/// <param name="vCollection">the collection to remove or its index or id</param>
					/// <returns>the removed collection or null</returns>
					public extern virtual sap.ui.ux3.Collection removeCollection(Union<int, string, sap.ui.ux3.Collection> vCollection);

					/// <summary>
					/// Checks for the provided <code>sap.ui.ux3.Collection</code> in the aggregation {@link #getCollections collections}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oCollection">The collection whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfCollection(sap.ui.ux3.Collection oCollection);

					/// <summary>
					/// Removes all the controls in the aggregation named <code>collections</code>.<br/> Additionally unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>an array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.ux3.Collection[] removeAllCollections();

					#endregion

					#region Methods for Aggregation content

					/// <summary>
					/// Gets content of aggregation {@link #getContent content}.
					/// 
					/// All controls that are currently displayed
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.Control[] getContent();

					/// <summary>
					/// Destroys all the content in the aggregation named <code>content</code>.
					/// </summary>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector destroyContent();

					/// <summary>
					/// Inserts a content into the aggregation named <code>content</code>.
					/// </summary>
					/// <param name="oContent">the content to insert; if empty, nothing is inserted</param>
					/// <param name="iIndex">the <code>0</code>-based index the content should be inserted at; for a negative value of <code>iIndex</code>, the content is inserted at position 0; for a value greater than the current size of the aggregation, the content is inserted at the last position</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector insertContent(sap.ui.core.Control oContent, int iIndex);

					/// <summary>
					/// Adds some content <code>oContent</code> to the aggregation named <code>content</code>.
					/// </summary>
					/// <param name="oContent">the content to add; if empty, nothing is inserted</param>
					/// <returns><code>this</code> to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector addContent(sap.ui.core.Control oContent);

					/// <summary>
					/// Removes a content from the aggregation named <code>content</code>.
					/// </summary>
					/// <param name="vContent">the content to remove or its index or id</param>
					/// <returns>the removed content or null</returns>
					public extern virtual sap.ui.core.Control removeContent(Union<int, string, sap.ui.core.Control> vContent);

					/// <summary>
					/// Checks for the provided <code>sap.ui.core.Control</code> in the aggregation {@link #getContent content}. and returns its index if found or -1 otherwise.
					/// </summary>
					/// <param name="oContent">The content whose index is looked for</param>
					/// <returns>The index of the provided control in the aggregation if found, or -1 otherwise</returns>
					public extern virtual int indexOfContent(sap.ui.core.Control oContent);

					/// <summary>
					/// Removes all the controls in the aggregation named <code>content</code>.<br/> Additionally unregisters them from the hosting UIArea.
					/// </summary>
					/// <returns>an array of the removed elements (might be empty)</returns>
					public extern virtual sap.ui.core.Control[] removeAllContent();

					#endregion

					#region Methods for Association selectedCollection

					/// <summary>
					/// ID of the element which is the current target of the association {@link #getSelectedCollection selectedCollection}, or <code>null</code>.
					/// </summary>
					/// <returns></returns>
					public extern virtual sap.ui.core.ID getSelectedCollection();

					/// <summary>
					/// Sets the associated {@link #getSelectedCollection selectedCollection}.
					/// </summary>
					/// <param name="oSelectedCollection">ID of an element which becomes the new target of this selectedCollection association; alternatively, an element instance may be given</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector setSelectedCollection(Union<sap.ui.core.ID, sap.ui.ux3.Collection> oSelectedCollection);

					#endregion

					#region Methods for Event collectionSelected

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:collectionSelected collectionSelected} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Event is fired if user selects a collection
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.CollectionInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachCollectionSelected(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:collectionSelected collectionSelected} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Event is fired if user selects a collection
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachCollectionSelected(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:collectionSelected collectionSelected} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Event is fired if user selects a collection
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachCollectionSelected(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:collectionSelected collectionSelected} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Event is fired if user selects a collection
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.CollectionInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachCollectionSelected(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:collectionSelected collectionSelected} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector detachCollectionSelected(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:collectionSelected collectionSelected} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector fireCollectionSelected(object mParameters);

					/// <summary>
					/// Fires event {@link #event:collectionSelected collectionSelected} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector fireCollectionSelected();

					#endregion

					#region Methods for Event itemSelectionChanged

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelectionChanged itemSelectionChanged} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Fires when an item in a collection is selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.CollectionInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachItemSelectionChanged(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelectionChanged itemSelectionChanged} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Fires when an item in a collection is selected
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachItemSelectionChanged(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelectionChanged itemSelectionChanged} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Fires when an item in a collection is selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachItemSelectionChanged(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:itemSelectionChanged itemSelectionChanged} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Fires when an item in a collection is selected
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.CollectionInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachItemSelectionChanged(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:itemSelectionChanged itemSelectionChanged} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector detachItemSelectionChanged(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:itemSelectionChanged itemSelectionChanged} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector fireItemSelectionChanged(object mParameters);

					/// <summary>
					/// Fires event {@link #event:itemSelectionChanged itemSelectionChanged} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector fireItemSelectionChanged();

					#endregion

					#region Methods for Event editCollection

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:editCollection editCollection} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Fires when the edit button is clicked
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.CollectionInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachEditCollection(object oData, sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:editCollection editCollection} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Fires when the edit button is clicked
					/// </summary>
					/// <param name="oData">An application-specific payload object that will be passed to the event handler along with the event object when firing the event</param>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachEditCollection(object oData, sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:editCollection editCollection} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Fires when the edit button is clicked
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachEditCollection(sap.ui.@base.EventDelegate fnFunction);

					/// <summary>
					/// Attaches event handler <code>fnFunction</code> to the {@link #event:editCollection editCollection} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// When called, the context of the event handler (its <code>this</code>) will be bound to <code>oListener</code> if specified, otherwise it will be bound to this <code>sap.ui.ux3.CollectionInspector</code> itself.
					/// 
					/// Fires when the edit button is clicked
					/// </summary>
					/// <param name="fnFunction">The function to be called when the event occurs</param>
					/// <param name="oListener">Context object to call the event handler with. Defaults to this <code>sap.ui.ux3.CollectionInspector</code> itself</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector attachEditCollection(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Detaches event handler <code>fnFunction</code> from the {@link #event:editCollection editCollection} event of this <code>sap.ui.ux3.CollectionInspector</code>.
					/// 
					/// The passed function and listener object must match the ones used for event registration.
					/// </summary>
					/// <param name="fnFunction">The function to be called, when the event occurs</param>
					/// <param name="oListener">Context object on which the given function had to be called</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector detachEditCollection(sap.ui.@base.EventDelegate fnFunction, object oListener);

					/// <summary>
					/// Fires event {@link #event:editCollection editCollection} to attached listeners.
					/// </summary>
					/// <param name="mParameters">Parameters to pass along with the event</param>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector fireEditCollection(object mParameters);

					/// <summary>
					/// Fires event {@link #event:editCollection editCollection} to attached listeners.
					/// </summary>
					/// <returns>Reference to <code>this</code> in order to allow method chaining</returns>
					public extern virtual sap.ui.ux3.CollectionInspector fireEditCollection();

					#endregion

					#region Other methods

					/// <summary>
					/// Closes the siedebar
					/// </summary>
					public extern virtual void closeSidebar();

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.CollectionInspector with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.CollectionInspector with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <param name="oClassInfo">Object literal with information about the class</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName, object oClassInfo);

					/// <summary>
					/// Creates a new subclass of class sap.ui.ux3.CollectionInspector with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
					/// 
					/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.core.Control.extend}.
					/// </summary>
					/// <param name="sClassName">Name of the class being created</param>
					/// <returns>Created class / constructor function</returns>
					public extern static object extend(string sClassName);

					/// <summary>
					/// Return the edit button
					/// </summary>
					public extern virtual void getEditButton();

					/// <summary>
					/// Returns a metadata object for class sap.ui.ux3.CollectionInspector.
					/// </summary>
					/// <returns>Metadata object describing this class</returns>
					public extern static sap.ui.@base.Metadata getMetadata();

					/// <summary>
					/// Opens the sidebar
					/// </summary>
					public extern virtual void openSidebar();

					#endregion

					#endregion

				}
			}
		}
	}
}
