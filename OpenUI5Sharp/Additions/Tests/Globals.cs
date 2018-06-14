using System;
using Bridge;

namespace OpenUI5Sharp
{
    /// <summary>
    /// Global variables and functions
    /// </summary>
    [External]
    public static partial class Globals
    {
        /// <summary>
        /// QUnit test adapter for opa.js has the same signature as a test of QUnit.
	    /// Suggested usage:
	    /// <pre><code>
	    /// sap.ui.require(["sap/ui/test/Opa5", "sap/ui/test/opaQunit"], function (Opa5, opaTest) {
	    ///
	    ///  Opa5.extendConfig({
	    ///      assertions: new Opa5({
	    ///          checkIfSomethingIsOk : function () {
	    ///              this.waitFor({
	    ///                  success: function () {
	    ///                      Opa5.assert.ok(true, "Everything is fine");
	    ///                  }
	    ///              });
	    ///          }
	    ///      })
	    ///  });
        ///
	    ///  opaTest("Should test something", function (Given, When, Then) {
	    ///     // Implementation of the test
	    ///     Then.checkIfSomethingIsOk();
	    ///  });
	    ///
	    /// });
	    /// </code></pre>
        /// When you require this file, it will also introduce a global variable: opaTest.
	    /// It will also alter some settings of QUnit.config - testTimout will be increased to 90 if you do not specify your own.
	    /// QUnit.reorder will be set to false, because OPA tests are often depending on each other.
        /// </summary>
        /// <param name="testName">The name of the created QUnit test.</param>
        /// <param name="expected">Integer showing how many QUnit assertions are expected by the test. If a function i passed, it is interpreted as callback and the expected is skipped.</param>
        /// <param name="callback">callback The test function. It will get 3 arguments passed to it.</param>
        /// <param name="async">for QUnit 1.x async tests</param>
        [Template("{@}({0}, {1}, {2}, {3})")]
        public extern static void opaTest(string testName, Union<string, object> expected, object callback, object async);

        /// <summary>
        /// QUnit test adapter for opa.js has the same signature as a test of QUnit.
	    /// Suggested usage:
	    /// <pre><code>
	    /// sap.ui.require(["sap/ui/test/Opa5", "sap/ui/test/opaQunit"], function (Opa5, opaTest) {
	    ///
	    ///  Opa5.extendConfig({
	    ///      assertions: new Opa5({
	    ///          checkIfSomethingIsOk : function () {
	    ///              this.waitFor({
	    ///                  success: function () {
	    ///                      Opa5.assert.ok(true, "Everything is fine");
	    ///                  }
	    ///              });
	    ///          }
	    ///      })
	    ///  });
        ///
	    ///  opaTest("Should test something", function (Given, When, Then) {
	    ///     // Implementation of the test
	    ///     Then.checkIfSomethingIsOk();
	    ///  });
	    ///
	    /// });
	    /// </code></pre>
        /// When you require this file, it will also introduce a global variable: opaTest.
	    /// It will also alter some settings of QUnit.config - testTimout will be increased to 90 if you do not specify your own.
	    /// QUnit.reorder will be set to false, because OPA tests are often depending on each other.
        /// </summary>
        /// <param name="testName">The name of the created QUnit test.</param>
        /// <param name="callback">callback The test function. It will get 3 arguments passed to it.</param>
        [Template("{@}({0}, {1})")]
        public extern static void opaTest(string testName, Action<sap.ui.test.Opa5, Map<sap.ui.test.Opa5>, Map<sap.ui.test.Opa5>> callback);
        // TODO: I'm ignoring the alias sap.ui.test.opaQunit
    }
}

     