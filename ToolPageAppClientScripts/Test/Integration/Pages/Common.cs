using Bridge;
using System;
using System.Linq;
using UI5;
using System.Collections.Generic;
using static Retyped.qunit;
using static Retyped.sinon.Sinon;

namespace ClientScripts.Test.Integration
{
    [FileName("test/integration/pages/common.js")]
    [Name("manu.toolpageapp.fv.test.integration.pages.Common")]
    public class Common : sap.ui.test.Opa5
    {
        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "sap/ui/test/Opa5"
                },
                new Func<object>(
                    () => {
                        Common newObj = Glue.CreateRawClassObject<Common>();
                        return sap.ui.test.Opa5.extend(nameof(Common), newObj);
                    }
                )
            );
        }

        public virtual string getFrameUrl(string sHash, string sUrlParameters)
        {
            string sUrl = jQuery.sap.getResourcePath("manu/toolpageapp/fv/app");
            if (sHash == null) {
                sHash = "";
            }
            sUrlParameters = (sUrlParameters != null) ? "?" + sUrlParameters : "";

            if (sHash.Length > 0) {
                sHash = "#" + (sHash.IndexOf("/") == 0 ? sHash.Substring(1) : sHash);
            } else {
                sHash = "";
            }

            return sUrl + sUrlParameters + sHash;
        }

        public virtual void iStartTheApp(object oOptions = null)
        {
            if (oOptions == null) {
                oOptions = new object();
            }
            // Start the app with a minimal delay to make tests run fast but still async to discover basic timing issues
            this.iStartMyAppInAFrame(getFrameUrl((string)oOptions["hash"], "serverDelay=50"));
        }

        public virtual Common iLookAtTheScreen()
        {
            return this;
        }
    }
}