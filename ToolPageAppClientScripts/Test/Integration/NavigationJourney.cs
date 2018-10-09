using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Tests;
using System.Collections.Generic;
using static Retyped.qunit;
using static Retyped.sinon.Sinon;

namespace ClientScripts.Test.Integration
{
    [FileName("test/integration/NavigationJourney.js")]
    public class NavigationJourney
    {
        [Init(InitPosition.Top)]
        public static void RequireScript()
        {
            jQuery.sap.require("sap.ui.qunit.qunit-css");
            jQuery.sap.require("sap.ui.thirdparty.qunit");
            jQuery.sap.require("sap.ui.qunit.qunit-junit");
            QUnit.config.autostart = false;
        }

        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "sap/ui/test/opaQunit",
                },
                new Action(() => {
                    QUnit.module("Desktop navigation");

                    TestsGlobals.opaTest("should press the error button and see a popover message",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Arrangements
                            Given.As<Common>().iStartTheApp();

                            //Actions
                            When.Get<OnTheAppPage>().iPressTheErrorButton();

                            //Assertions
                            Then.Get<OnTheAppPage>().iShouldSeeTheErrorPopover();
                        }
                    );

                    TestsGlobals.opaTest("should press the notification button and see a popover message",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheAppPage>().iPressTheNotificationButton();

                            //Assertions
                            Then.Get<OnTheAppPage>().iShouldSeeTheNotificationPopover();
                        }
                    );

                    TestsGlobals.opaTest("should press the user button and see a popover message",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheAppPage>().iPressTheUserButton();

                            //Assertions
                            Then.Get<OnTheAppPage>().iShouldSeeTheUserPopover();
                        }
                    );

                    TestsGlobals.opaTest("should press the settings button and navigate to settings view",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheAppPage>().iPressTheSettingsButton();

                            //Assertions
                            Then.Get<OnTheSettingsPage>().iShouldSeeMasterSettingsView();
                            Then.Get<OnTheSettingsPage>().iShouldSeeDetailSettingsView();
                        }
                    );

                    TestsGlobals.opaTest("should press the order settings item and see a toast message",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheSettingsPage>().iPressTheOrderSettingsItem();

                            //Assertions
                            Then.Get<OnTheSettingsPage>().iShouldSeeMessageToast();
                        }
                    );

                    TestsGlobals.opaTest("should press the save button  and see a toast message",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheSettingsPage>().iPressTheSaveButton();

                            //Assertions
                            Then.Get<OnTheSettingsPage>().iShouldSeeMessageToast();
                        }
                    );

                    TestsGlobals.opaTest("should press the cancel button  and see a toast message",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheSettingsPage>().iPressTheCancelButton();

                            //Assertions
                            Then.Get<OnTheSettingsPage>().iShouldSeeMessageToast();
                        }
                    );

                    TestsGlobals.opaTest("should press the statistics button and navigate to statistics view",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheAppPage>().iPressTheStatisticsButton();

                            //Assertions
                            Then.Get<OnTheStatisticsPage>().iShouldSeeTheStatisticsView();
                            Then.Get<OnTheStatisticsPage>().iShouldSeeTheCharts();
                        }
                    );

                    TestsGlobals.opaTest("should press the refresh button",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheStatisticsPage>().iPressTheRefreshButton();

                            //Assertions
                            Then.Get<OnTheStatisticsPage>().iShouldSeeTheBusyIndicator();
                        }
                    );

                    TestsGlobals.opaTest("should press the usage statistics button and see a toast message",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheAppPage>().iPressTheUsageStatisticsButton();

                            //Assertions
                            Then.Get<OnTheAppPage>().iShouldSeeMessageToast();
                        }
                    );

                    TestsGlobals.opaTest("should press the order statistics button and see a toast message",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheAppPage>().iPressTheOrderStatisticsButton();

                            //Assertions
                            Then.Get<OnTheAppPage>().iShouldSeeMessageToast();
                        }
                    );

                    TestsGlobals.opaTest("should press the home button and navigate to home view",
                        (sap.ui.test.Opa5 Given, Map<sap.ui.test.Opa5> When, Map<sap.ui.test.Opa5> Then) => {
                            //Actions
                            When.Get<OnTheAppPage>().iPressTheHomeButton();

                            //Assertions
                            Then.Get<OnTheHomePage>().iShouldSeeTheHomeView();
                        }
                    );
                })
            );
        }
   }
}