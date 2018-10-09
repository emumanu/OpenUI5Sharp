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
			public static partial class model
			{
				public static partial class analytics
				{
					/// <summary>
					/// Simple Response Collection Component, collects the responses for each sub-request inside a bigger batch request.
					/// 
					/// Also handles clean-up after all responses (either success or error) have been collected. Instantiated in AnalyticalBinding.prototype._executeBatchRequest()
					/// </summary>
					[External]
					[Namespace(false)]
					[Name("sap.ui.model.analytics.BatchResponseCollector")]
					public partial class BatchResponseCollector
					{
						#region Typed Parameters

						/// <summary>
						/// Parameter to be used as Object Literal
						/// </summary>
						[External]
						[ObjectLiteral]
						public partial class SetupInfo
						{
							/// <summary>
							/// an Array with detail information for all executed batch sub-requests
							/// </summary>
							public object[] executedRequests;

							/// <summary>
							/// a reference to the AnalyticalBinding which started the batch request
							/// </summary>
							public object binding;

							/// <summary>
							/// the analyticalInfo version at the time of the creation of this BatchResponseCollector instance, this may change during the process of a pending request. Typically changed via a call to AnalyticalBinding#updateAnalyticalInfo.
							/// </summary>
							public int lastAnalyticalInfoVersion;

						}

						#endregion

						#region Constructor

						/// <summary>
						/// Constructor for a batch response collecting component.
						/// </summary>
						/// <param name="mParams">optional Setup-Parameter, @see BatchResponseCollector#setup</param>
						public extern BatchResponseCollector(object mParams);

						/// <summary>
						/// Constructor for a batch response collecting component.
						/// </summary>
						public extern BatchResponseCollector();

						#endregion

						#region Methods

						/// <summary>
						/// Collects responses of type BatchResponseCollector.TYPE_SUCCESS and BatchResponseCollector.TYPE_ERROR.
						/// 
						/// Keeps track of all collected responses and fires the necessary events after all responses for the requests, given in the constructor, have returned.
						/// </summary>
						/// <param name="oResponse">the response which should be collected</param>
						/// <param name="sResponseType">the type of the response, either BatchResponseCollector.TYPE_SUCCESS or BatchResponseCollector.TYPE_ERROR</param>
						public extern virtual void collect(object oResponse, string sResponseType);

						/// <summary>
						/// Collects responses of type BatchResponseCollector.TYPE_SUCCESS and BatchResponseCollector.TYPE_ERROR.
						/// 
						/// Keeps track of all collected responses and fires the necessary events after all responses for the requests, given in the constructor, have returned.
						/// </summary>
						/// <param name="oResponse">the response which should be collected</param>
						public extern virtual void collect(object oResponse);

						/// <summary>
						/// Convenience function to collect an error response.
						/// 
						/// Internally BatchResponseCollector#collect is called, the second parameter is set to BatchResponseCollector.TYPE_ERROR
						/// </summary>
						/// <param name="oResponse">the erroneous response object</param>
						public extern virtual void error(object oResponse);

						/// <summary>
						/// Setup-Function to initialize/reset the BatchResponseCollector.
						/// </summary>
						/// <param name="mParams">optional Setup-Parameter</param>
						public extern virtual void setup(sap.ui.model.analytics.BatchResponseCollector.SetupInfo mParams);

						/// <summary>
						/// Setup-Function to initialize/reset the BatchResponseCollector.
						/// </summary>
						public extern virtual void setup();

						/// <summary>
						/// Convenience function to collect a success response.
						/// 
						/// Internally BatchResponseCollector#collect is called with second parameter BatchResponseCollector.TYPE_SUCCESS
						/// </summary>
						/// <param name="oResponse">the successful response, which should be collected</param>
						public extern virtual void success(object oResponse);

						#endregion

					}
				}
			}
		}
	}
}
