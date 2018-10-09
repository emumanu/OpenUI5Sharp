Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("ClientScripts.Test.Integration.OnTheStatisticsPage", {
        inherits: [UI5.Tests.BaseIntegrationPage],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[sap.ui.test.Opa5],"pi":[{"n":"Opa5","pt":sap.ui.test.Opa5,"ps":0}],"sn":"ctor"},{"a":2,"n":"RequireScript","is":true,"t":8,"sn":"RequireScript","rt":System.Void},{"at":[new UI5.Tests.OpaActionAttribute()],"v":true,"a":2,"n":"iPressTheRefreshButton","t":8,"sn":"iPressTheRefreshButton","rt":Bridge.virtualc("JQueryPromise")},{"at":[new UI5.Tests.OpaAssertionAttribute()],"v":true,"a":2,"n":"iShouldSeeTheBusyIndicator","t":8,"sn":"iShouldSeeTheBusyIndicator","rt":Bridge.virtualc("JQueryPromise")},{"at":[new UI5.Tests.OpaAssertionAttribute()],"v":true,"a":2,"n":"iShouldSeeTheCharts","t":8,"sn":"iShouldSeeTheCharts","rt":Bridge.virtualc("JQueryPromise")},{"at":[new UI5.Tests.OpaAssertionAttribute()],"v":true,"a":2,"n":"iShouldSeeTheStatisticsView","t":8,"sn":"iShouldSeeTheStatisticsView","rt":Bridge.virtualc("JQueryPromise")},{"a":2,"n":"sChartViewName","t":4,"rt":System.String,"sn":"sChartViewName"},{"a":2,"n":"sViewName","t":4,"rt":System.String,"sn":"sViewName"}]}; },
        fields: {
            sViewName: null,
            sChartViewName: null
        },
        ctors: {
            ctor: function (Opa5) {
                this.$initialize();
                UI5.Tests.BaseIntegrationPage.ctor.call(this, Opa5);
            }
        },
        methods: {
            iPressTheRefreshButton: function () {
                return this.waitFor({ id: "refresh", viewName: this.sViewName, actions: new sap.ui.test.actions.Press(), errorMessage: "Did not find the refresh button on the statistics page" });
            },
            iShouldSeeTheStatisticsView: function () {
                return this.waitFor({ viewName: this.sViewName, success: Bridge.fn.bind(this, function (obj) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.ok(this.sViewName, "The statistics view was displayed");
                }), errorMessage: "The statistics view was not displayed" });
            },
            iShouldSeeTheBusyIndicator: function () {
                return this.waitFor({ id: "statisticsBlockLayout", viewName: this.sChartViewName, success: function (oView) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.ok(oView, "The busy indicator was displayed");
                }, errorMessage: "The busy indicator was not displayed" });
            },
            iShouldSeeTheCharts: function () {
                this.waitFor({ controlType: "manu.toolpageapp.fv.control.D3PieChart", viewName: this.sChartViewName, success: function (aCharts) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.ok(aCharts.length === 2, "Two pie charts are displayed");
                }, errorMessage: "The pie charts are not displayed" });

                this.waitFor({ controlType: "manu.toolpageapp.fv.control.D3ColumnChart", viewName: this.sChartViewName, success: function (aCharts) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.ok(aCharts.length === 2, "Two column charts are displayed");
                }, errorMessage: "The column charts are not displayed" });

                this.waitFor({ controlType: "manu.toolpageapp.fv.control.D3ComparisonChart", viewName: this.sChartViewName, success: function (aCharts) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.ok(aCharts.length === 2, "Two comparison charts are displayed");
                }, errorMessage: "The comparison charts are not displayed" });

                return this.waitFor({ controlType: "manu.toolpageapp.fv.control.D3Chart", viewName: this.sChartViewName, success: function (aCharts) {
                    UI5.Tests.BaseIntegrationPage.Opa5.assert.strictEqual(aCharts.length, 6, "Six D3 charts are displayed");
                }, errorMessage: "The D3 charts are not displayed" });
            }
        }
    });
});

sap.ui.require(System.Array.init(["sap/ui/test/Opa5", "manu/toolpageapp/fv/test/integration/pages/Common", "sap/ui/test/matchers/PropertyStrictEquals", "sap/ui/test/actions/Press"], System.String), (function (Opa5, Common) {
    var map = { };

    var testPage = new ClientScripts.Test.Integration.OnTheStatisticsPage(Opa5);
    testPage.sViewName = "Statistics";
    testPage.sChartViewName = (testPage.sViewName || "") + "D3";

    var cpo = testPage.GetPageObject();
    cpo.baseClass = Common;
    map['ClientScripts.Test.Integration.OnTheStatisticsPage'] = cpo;

    sap.ui.test.Opa5.createPageObjects(map);
}));
