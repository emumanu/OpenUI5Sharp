using Bridge;
using System;
using System.Linq;
using UI5;
using System.Collections.Generic;
using static Retyped.qunit;
using static Retyped.sinon.Sinon;

namespace ClientScripts.Test.Unit
{
    [FileName("test/unit/allTests.js")]
    public class AllTests
    {
        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "test/unit/model/formatter",
                    "test/unit/model/models"
                },
                new Action(() => {
                })
            );
        }
   }
}