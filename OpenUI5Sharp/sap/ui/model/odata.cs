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
			public static partial class model
			{
				/// <summary>
				/// OData-based DataBinding Utility Class
				/// </summary>
				[External]
				[Namespace(false)]
				public static partial class odata
				{
					#region Methods

					/// <summary>
					/// Adapter for TreeBindings to add the ListBinding functionality and use the tree structure in list based controls. Only usable with the sap.ui.table.TreeTable control. The functions defined here are only available when you are using a TreeTable and an ODataModel.
					/// </summary>
					public extern static void ODataTreeBindingAdapter();

					/// <summary>
					/// Adapter for TreeBindings to add the ListBinding functionality and use the tree structure in list based controls.
					/// </summary>
					public extern static void ODataTreeBindingFlat();

					#endregion

					/// <summary>
					/// Different modes for retrieving the count of collections
					/// </summary>
					[External]
					[Namespace(false)]
					public enum BatchMode
					{
							/// <summary>
							/// Batch grouping enabled
							/// </summary>
							Group,
							/// <summary>
							/// No batch requests
							/// </summary>
							None,
					}
					/// <summary>
					/// Different modes for retrieving the count of collections.
					/// </summary>
					[External]
					[Namespace(false)]
					public enum CountMode
					{
							/// <summary>
							/// Count is retrieved by a separate request upfront and inline with each data request.
							/// 
							/// The only purpose of this mode is to reflect the behavior of the {@link sap.ui.model.odata.ODataModel ODataModel (v1)} before the introduction of the <code>CountMode</code>. For compatibility reasons, it is the default for the <code>ODataModel</code> (v1) and shouldn't be used otherwise.
							/// </summary>
							Both,
							/// <summary>
							/// Count is retrieved by adding <code>$inlinecount=allpages</code> to data requests as long as no count has been determined yet.
							/// </summary>
							Inline,
							/// <summary>
							/// Count is retrieved by adding <code>$inlinecount=allpages</code> to every data request.
							/// </summary>
							InlineRepeat,
							/// <summary>
							/// Count is not requested from the server.
							/// </summary>
							None,
							/// <summary>
							/// Count is retrieved by sending a separate <code>$count</code> request before requesting data.
							/// 
							/// It depends on the concrete model implementation whether and how the <code>$count</code> request and the data request are synchronized.
							/// </summary>
							Request,
					}
					/// <summary>
					/// Different methods for update operations.
					/// </summary>
					[External]
					[Namespace(false)]
					public enum UpdateMethod
					{
							/// <summary>
							/// Update requests will be send with HTTP method <code>MERGE</code>.
							/// </summary>
							Merge,
							/// <summary>
							/// Update requests will be send with HTTP method <code>PUT</code>.
							/// </summary>
							Put,
					}
					/// <summary>
					/// Different modes for executing service operations (filtering, sorting)
					/// </summary>
					[External]
					[Namespace(false)]
					public enum OperationMode
					{
							/// <summary>
							/// With operation mode <code>Auto</code>, operations are either processed on the client or on the server. The exact behavior depends on the configured {@link sap.ui.model.odata.CountMode CountMode}, on the <code>threshold</code> and on the size of the data: <ol> <li>Count Modes <code>Request</code> and <code>Both</code><br> Initially the binding will issue a <code>$count</code> request without any filters/sorters. <ol type="a"> <li>If the count is lower or equal to the threshold, the binding will behave like in operation mode <code>Client</code>, and a data request for all entries is issued.</li> <li>If the count exceeds the threshold, the binding will behave like in operation mode <code>Server</code>.</li> </ol> </li>
							/// 
							/// <li>Count Modes <code>Inline</code> or </code>InlineRepeat<code><br> The initial request tries to fetch as many entries as configured with the <code>threshold</code> parameter, without specifying any filters/sorters. In addition, the query parameter <code>$inlinecount</code> is added. The binding assumes, that the threshold given by the application can be met, but it adapts its behavior depending on the response: <ol type="a"> <li>If the response returns fewer (or just as many) entries as the threshold, the binding will behave exactly like when using the operation mode <code>Client</code>. Initially configured filters/sorters will be applied afterwards on the client.</li> <li>If the <code>$inlinecount</code> is higher than the threshold, the binding will behave like in operation mode <code>Server</code>. In this case a new data request containing the initially set filters/sorters will be issued.</li> </ol> It is up to the application to chose an appropriate threshold value. Ideally, it should be high enough to fetch all data in the most common scenarios (to avoid a fallback to operation mode <code>Server</code>, requiring an additional request), but it also should be low enough to ensure a fast response in case there is much more data than expected. </li> <li>Count mode <code>None</code> is not supported together with operation mode <code>Auto</code></li> </ol>
							/// </summary>
							Auto,
							/// <summary>
							/// Operations are executed on the client. This only works if all entries are loaded on the client. The initial request fetches the complete collection, filtering and sorting does not trigger further requests.
							/// </summary>
							Client,
							/// <summary>
							/// By default, all operations are executed on the server in the OData service request (<code>Server</code> mode). Only if the collection is already expanded and all entries are available on the client, all operations are executed on the client (<code>Client</code> mode).
							/// </summary>
							Default,
							/// <summary>
							/// Operations are executed on the server in the OData service request, by appending corresponding URL parameters (<code>$filter</code>, <code>$orderby</code>). Each change in filtering or sorting triggers a new request to the server.
							/// </summary>
							Server,
					}
				}
			}
		}
	}
}
