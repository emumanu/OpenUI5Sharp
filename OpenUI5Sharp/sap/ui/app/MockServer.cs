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
			public static partial class app
			{
				/// <summary>
				/// Class to mock a server
				/// </summary>
				[External]
				[Namespace(false)]
				[Obsolete("Deprecated since 1.15.1. The mock server code has been moved to sap.ui.core.util - see {@link sap.ui.core.util.MockServer}")]
				public abstract partial class MockServer : sap.ui.@base.ManagedObject
				{
					#region Settings

					/// <summary>
					/// Settings class to create the object
					/// </summary>
					[External]
					[ObjectLiteral]
					public partial class Settings : sap.ui.@base.ManagedObject.Settings
					{
					}

					#endregion

					#region Constructor

					/// <summary>
					/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
					/// </summary>
					/// <param name="sId">id for the new server object; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
					/// <param name="oScope">scope object for resolving string based type and formatter references in bindings</param>
					public extern MockServer(string sId, sap.ui.app.MockServer.Settings mSettings, object oScope);

					/// <summary>
					/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
					/// </summary>
					/// <param name="sId">id for the new server object; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
					public extern MockServer(string sId, sap.ui.app.MockServer.Settings mSettings);

					/// <summary>
					/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
					/// </summary>
					/// <param name="sId">id for the new server object; generated automatically if no non-empty id is given Note: this can be omitted, no matter whether <code>mSettings</code> will be given or not!</param>
					public extern MockServer(string sId);

					/// <summary>
					/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
					/// </summary>
					public extern MockServer();

					/// <summary>
					/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
					/// </summary>
					/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
					public extern MockServer(sap.ui.app.MockServer.Settings mSettings);

					/// <summary>
					/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
					/// </summary>
					/// <param name="mSettings">optional map/JSON-object with initial property values, aggregated objects etc. for the new object</param>
					/// <param name="oScope">scope object for resolving string based type and formatter references in bindings</param>
					public extern MockServer(sap.ui.app.MockServer.Settings mSettings, object oScope);

					/// <summary>
					/// Creates a mocked server. This helps to mock all or some backend calls, e.g. for OData/JSON Models or simple XHR calls, without changing the application code. This class can also be used for qunit tests.
					/// </summary>
					/// <param name="oScope">scope object for resolving string based type and formatter references in bindings</param>
					public extern MockServer(object oScope);

					#endregion

				}
			}
		}
	}
}
