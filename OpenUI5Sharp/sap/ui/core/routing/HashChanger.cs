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
				public static partial class routing
				{
					/// <summary>
					/// Class for manipulating and receiving changes of the browserhash with the hasher framework. Fires a "hashChanged" event if the browser hash changes.
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.core.routing.HashChanger")]
					public partial class HashChanger : sap.ui.@base.EventProvider
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class HashChangedInfo
						{
							/// <summary>
							/// The URL hash before it's changed
							/// </summary>
							public string oldHash;

							/// <summary>
							/// The new URL hash
							/// </summary>
							public object newHash;

						}

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class HashInfo
						{
							/// <summary>
							/// The URL hash
							/// </summary>
							public string sHash;

						}

						#endregion

						#region Delegates

						public delegate void HashChangedDelegate(sap.ui.@base.Event<sap.ui.core.routing.HashChanger.HashChangedInfo> oEvent, object oData);

						public delegate void HashDelegate(sap.ui.@base.Event<sap.ui.core.routing.HashChanger.HashInfo> oEvent, object oData);

						#endregion

						#region Constructor

						public extern HashChanger();

						#endregion

						#region Methods

						#region Methods for event hashChanged

						/// <summary>
						/// Fires the hashchanged event, may be extended to modify the hash before fireing the event
						/// </summary>
						/// <param name="newHash">the new hash of the browser</param>
						/// <param name="oldHash">the previous hash</param>
						public extern virtual void fireHashChanged(string newHash, string oldHash);

						#endregion

						#region Other methods

						/// <summary>
						/// Cleans the event registration
						/// </summary>
						public extern override void destroy();

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.HashChanger with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <param name="FNMetaImpl">Constructor function for the metadata object; if not given, it defaults to <code>sap.ui.core.ElementMetadata</code></param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo, object FNMetaImpl);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.HashChanger with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <param name="oClassInfo">Object literal with information about the class</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName, object oClassInfo);

						/// <summary>
						/// Creates a new subclass of class sap.ui.core.routing.HashChanger with name <code>sClassName</code> and enriches it with the information contained in <code>oClassInfo</code>.
						/// 
						/// <code>oClassInfo</code> might contain the same kind of information as described in {@link sap.ui.base.EventProvider.extend}.
						/// </summary>
						/// <param name="sClassName">Name of the class being created</param>
						/// <returns>Created class / constructor function</returns>
						public extern static object extend(string sClassName);

						/// <summary>
						/// Gets the current hash
						/// </summary>
						/// <returns>the current hash</returns>
						public extern virtual string getHash();

						/// <summary>
						/// Gets a global singleton of the HashChanger. The singleton will get created when this function is invoked for the first time.
						/// </summary>
						public extern static void getInstance();

						/// <summary>
						/// Returns a metadata object for class sap.ui.core.routing.HashChanger.
						/// </summary>
						/// <returns>Metadata object describing this class</returns>
						[Name("getMetadata")]
						public extern static sap.ui.@base.Metadata getMetadataStatic();

						/// <summary>
						/// Will start listening to hashChanges with the parseHash function. This will also fire a hashchanged event with the initial hash.
						/// </summary>
						/// <returns>false if it was initialized before, true if it was initialized the first time</returns>
						public extern virtual void init();

						/// <summary>
						/// Replaces the hash to a certain value. When using the replace function no browser history is written. If you want to have an entry in the browser history, please use set setHash function.
						/// </summary>
						/// <param name="sHash">the hash</param>
						public extern virtual void replaceHash(string sHash);

						/// <summary>
						/// Sets the hashChanger to a new instance, destroys the old one and copies all its event listeners to the new one
						/// </summary>
						/// <param name="oHashChanger">the new instance for the global singleton</param>
						public extern static void replaceHashChanger(sap.ui.core.routing.HashChanger oHashChanger);

						/// <summary>
						/// Sets the hash to a certain value. When using the set function a browser history entry is written. If you do not want to have an entry in the browser history, please use set replaceHash function.
						/// </summary>
						/// <param name="sHash">the hash</param>
						public extern virtual void setHash(string sHash);

						#endregion

						#endregion

					}
				}
			}
		}
	}
}
