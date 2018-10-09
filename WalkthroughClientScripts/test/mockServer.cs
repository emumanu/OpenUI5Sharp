using Bridge;
using System;
using System.Linq;
using static Retyped.qunit;
using UI5;

namespace WalkthroughClientScripts.Tests
{
    [FileName("localService/mockserver.js")]
    public class MockServer
    {
        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/util/MockServer"
                }, new Func<MockServer>(() => {
                    var newObj = Glue.CreateRawClassObject<MockServer>();
                    return newObj;
                })
            );
        }

        public virtual void init()
        {
            var oMockServer = new sap.ui.core.util.MockServer(new {
                rootUri = "https://cors-anywhere.herokuapp.com/services.odata.org/V2/Northwind/Northwind.svc/"
            });

			var oUriParameters = jQuery.sap.getUriParameters((string)Bridge.Script.Undefined);

            // configure mock server with a delay
            sap.ui.core.util.MockServer.config(new sap.ui.core.util.MockServer.Config() {
                autoRespond = true,
                autoRespondAfter = (int?)(oUriParameters.get<int?>("serverDelay")) ?? 1000
			});

			// simulate
			var sPath = jQuery.sap.getModulePath("sap.ui.demo.walkthrough.localService");
            oMockServer.simulate(sPath + "/metadata.xml", new sap.ui.core.util.MockServer.SimulateInfo() {
                sMockdataBaseUrl = sPath + "/mockdata"
            });

			// start
			oMockServer.start();
        }
    }
}
