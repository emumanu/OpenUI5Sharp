using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using UI5;
using UI5.Tests;
using Retyped;

namespace ClientScripts.Test.Integration
{
    [FileName("test/integration/pages/Statistics.js")]
    public class OnTheStatisticsPage : BaseIntegrationPage
    {
        public string sViewName;
        public string sChartViewName;

        [Init(InitPosition.Bottom)]
        public static void RequireScript()
        {
            sap.ui.require(new string[] {
                    "sap/ui/test/Opa5",
                    "manu/toolpageapp/fv/test/integration/pages/Common",
                    "sap/ui/test/matchers/PropertyStrictEquals",
                    "sap/ui/test/actions/Press"
                },
                (new Action<sap.ui.test.Opa5, Common>((Opa5, Common) => {
                    var map = new Map<CreatePageObjectsInfo>();

                    OnTheStatisticsPage testPage = new OnTheStatisticsPage(Opa5);
                    testPage.sViewName = "Statistics";
                    testPage.sChartViewName = testPage.sViewName + "D3";

                    CreatePageObjectsInfo cpo = testPage.GetPageObject();
                    cpo.baseClass = Common;
                    map.Set<OnTheStatisticsPage>(cpo);

                    createPageObjects(map);
                })
            ));
        }

        public OnTheStatisticsPage(sap.ui.test.Opa5 Opa5) : base(Opa5)
        {
        }

        [OpaAction]
        public virtual jquery.JQueryPromise<object> iPressTheRefreshButton()
        {
            return this.waitFor(new WaitForOptions() {
                id = "refresh",
                viewName = sViewName,
                actions = new sap.ui.test.actions.Press(),
                errorMessage = "Did not find the refresh button on the statistics page"
            });
        }

        [OpaAssertion]
        public virtual jquery.JQueryPromise<object> iShouldSeeTheStatisticsView()
        {
            return this.waitFor(new WaitForOptions() {
                viewName = sViewName,
                success = (Action<object>)((object obj) => {
                    Opa5.assert.ok(sViewName, "The statistics view was displayed");
                }),
                errorMessage = "The statistics view was not displayed"
            });
        }

        [OpaAssertion]
        public virtual jquery.JQueryPromise<object> iShouldSeeTheBusyIndicator()
        {
            return this.waitFor(new WaitForOptions() {
                id = "statisticsBlockLayout",
                viewName = sChartViewName,
                success = (Action<object>)((object oView) => {
                    Opa5.assert.ok(oView, "The busy indicator was displayed");
                }),
                errorMessage = "The busy indicator was not displayed"
            });
        }

        [OpaAssertion]
        public virtual jquery.JQueryPromise<object> iShouldSeeTheCharts()
        {
            this.waitFor(new WaitForOptions() {
                controlType = "manu.toolpageapp.fv.control.D3PieChart",
                viewName = sChartViewName,
                success = (Action<object[]>)((object[] aCharts) => {
                    Opa5.assert.ok(aCharts.Length == 2, "Two pie charts are displayed");
                }),
                errorMessage = "The pie charts are not displayed"
            });

            this.waitFor(new WaitForOptions() {
                controlType = "manu.toolpageapp.fv.control.D3ColumnChart",
                viewName = sChartViewName,
                success = (Action<object[]>)((object[] aCharts) => {
                    Opa5.assert.ok(aCharts.Length == 2, "Two column charts are displayed");
                }),
                errorMessage = "The column charts are not displayed"
            });

            this.waitFor(new WaitForOptions() {
                controlType = "manu.toolpageapp.fv.control.D3ComparisonChart",
                viewName = sChartViewName,
                success = (Action<object[]>)((object[] aCharts) => {
                    Opa5.assert.ok(aCharts.Length == 2, "Two comparison charts are displayed");
                }),
                errorMessage = "The comparison charts are not displayed"
            });

            return this.waitFor(new WaitForOptions() {
                controlType = "manu.toolpageapp.fv.control.D3Chart",
                viewName = sChartViewName,
                success = (Action<object[]>)((object[] aCharts) => {
                    Opa5.assert.strictEqual(aCharts.Length, 6, "Six D3 charts are displayed");
                }),
                errorMessage = "The D3 charts are not displayed"
            });
        }
    }
}
