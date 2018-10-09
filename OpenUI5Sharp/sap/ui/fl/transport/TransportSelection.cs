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
			public static partial class fl
			{
				public static partial class transport
				{
					[External]
					[Namespace(false)]
					[Name("sap.ui.fl.transport.TransportSelection")]
					public partial class TransportSelection
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class _prepareChangesForTransportInfo
						{
							/// <summary>
							/// name of the package
							/// </summary>
							public string packageName;

							/// <summary>
							/// ID of the transport
							/// </summary>
							public string transport;

						}

						#endregion

						#region Constructor

						/// <param name="Utils">a reference to the flexibility utilities implementation.</param>
						/// <param name="Transports">a reference to the transport service implementation.</param>
						/// <param name="TransportDialog">a reference to the transport dialog implementation.</param>
						/// <param name="FlexSettings">a reference to the settings implementation</param>
						public extern TransportSelection(object Utils, object Transports, sap.ui.fl.transport.TransportDialog TransportDialog, object FlexSettings);

						#endregion

						#region Methods

						/// <summary>
						/// Prepare all changes and assign them to an existing transport.
						/// </summary>
						/// <param name="oTransportInfo">object containing the package name and the transport</param>
						/// <param name="aAllLocalChanges">array that includes all local changes</param>
						/// <returns>Returns a Promise which resolves without parameters</returns>
						public extern virtual jquery.JQueryPromise<object> _prepareChangesForTransport(object oTransportInfo, object[] aAllLocalChanges);

						/// <summary>
						/// Checks transport info object
						/// </summary>
						/// <param name="oTransportInfo">transport info object</param>
						/// <returns>returns true if transport info is complete</returns>
						public extern virtual bool checkTransportInfo(object oTransportInfo);

						/// <summary>
						/// Checks transport info object
						/// </summary>
						/// <returns>returns true if transport info is complete</returns>
						public extern virtual bool checkTransportInfo();

						/// <summary>
						/// Opens the transport selection dialog
						/// </summary>
						/// <param name="oChange">the change for which the transport information should be retrieved</param>
						/// <param name="oControl"></param>
						/// <returns>promise that resolves</returns>
						public extern virtual jquery.JQueryPromise<object> openTransportSelection(object oChange, object oControl);

						/// <summary>
						/// Opens the transport selection dialog
						/// </summary>
						/// <param name="oControl"></param>
						/// <returns>promise that resolves</returns>
						public extern virtual jquery.JQueryPromise<object> openTransportSelection(object oControl);

						/// <summary>
						/// Selects a transport request for a given LREP object. First checks if the Adaptation Transport Organizer (ATO) is enabled If ATO is enabled and the layered repository object is in the CUSTOMER layer, the request 'ATO_NOTIFICATION' has to be used. This request triggers in the back end that the change is added to an ATO collection. If ATO is not enabled or LREP object not in CUSTOMER layer: If the LREP object is already assigned to an open transport request or the LREP object is assigned to a local ABAP package, no dialog to select a transport is started. Instead the success callback is invoked directly. The transport dialog is shown if a package or a transport request has still to be selected, so if more than one transport request is available for the current user and the LREP object is not locked in an open transport request.
						/// </summary>
						/// <param name="oObjectInfo">the LREP object, which has the attributes name, name space, type, layer and package.</param>
						/// <param name="fOkay">call-back to be invoked when a transport request has successfully been selected.</param>
						/// <param name="fError">call-back to be invoked when an error occurred during selection of a transport request.</param>
						/// <param name="bCompactMode">flag indicating whether the transport dialog should be opened in compact mode.</param>
						/// <param name="oControl">Control instance</param>
						public extern virtual void selectTransport(object oObjectInfo, object fOkay, object fError, bool bCompactMode, object oControl);

						/// <summary>
						/// Sets the transports for all changes.
						/// </summary>
						/// <param name="aChanges">array of {sap.ui.fl.Change}</param>
						/// <param name="oControl">object of the root control for the transport</param>
						/// <returns>promise that resolves without parameters</returns>
						public extern virtual jquery.JQueryPromise<object> setTransports(object[] aChanges, object oControl);

						#endregion

					}
				}
			}
		}
	}
}
