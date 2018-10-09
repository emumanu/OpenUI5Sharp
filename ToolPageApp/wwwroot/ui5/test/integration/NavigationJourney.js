jQuery.sap.require("sap.ui.qunit.qunit-css");
jQuery.sap.require("sap.ui.thirdparty.qunit");
jQuery.sap.require("sap.ui.qunit.qunit-junit");
QUnit.config.autostart = false;

Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("ClientScripts.Test.Integration.NavigationJourney", {
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"a":2,"n":"RequireScript","is":true,"t":8,"sn":"RequireScript","rt":System.Void}]}; }
    });
});

sap.ui.define(System.Array.init(["sap/ui/test/opaQunit"], System.String), function () {
    QUnit.module("Desktop navigation");

    opaTest("should press the error button and see a popover message", function (Given, When, Then) {
        //Arrangements
        Given.iStartTheApp();

        //Actions
        When['ClientScripts.Test.Integration.OnTheAppPage'].iPressTheErrorButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheAppPage'].iShouldSeeTheErrorPopover();
    });

    opaTest("should press the notification button and see a popover message", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheAppPage'].iPressTheNotificationButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheAppPage'].iShouldSeeTheNotificationPopover();
    });

    opaTest("should press the user button and see a popover message", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheAppPage'].iPressTheUserButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheAppPage'].iShouldSeeTheUserPopover();
    });

    opaTest("should press the settings button and navigate to settings view", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheAppPage'].iPressTheSettingsButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheSettingsPage'].iShouldSeeMasterSettingsView();
        Then['ClientScripts.Test.Integration.OnTheSettingsPage'].iShouldSeeDetailSettingsView();
    });

    opaTest("should press the order settings item and see a toast message", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheSettingsPage'].iPressTheOrderSettingsItem();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheSettingsPage'].iShouldSeeMessageToast();
    });

    opaTest("should press the save button  and see a toast message", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheSettingsPage'].iPressTheSaveButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheSettingsPage'].iShouldSeeMessageToast();
    });

    opaTest("should press the cancel button  and see a toast message", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheSettingsPage'].iPressTheCancelButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheSettingsPage'].iShouldSeeMessageToast();
    });

    opaTest("should press the statistics button and navigate to statistics view", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheAppPage'].iPressTheStatisticsButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheStatisticsPage'].iShouldSeeTheStatisticsView();
        Then['ClientScripts.Test.Integration.OnTheStatisticsPage'].iShouldSeeTheCharts();
    });

    opaTest("should press the refresh button", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheStatisticsPage'].iPressTheRefreshButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheStatisticsPage'].iShouldSeeTheBusyIndicator();
    });

    opaTest("should press the usage statistics button and see a toast message", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheAppPage'].iPressTheUsageStatisticsButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheAppPage'].iShouldSeeMessageToast();
    });

    opaTest("should press the order statistics button and see a toast message", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheAppPage'].iPressTheOrderStatisticsButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheAppPage'].iShouldSeeMessageToast();
    });

    opaTest("should press the home button and navigate to home view", function (Given, When, Then) {
        //Actions
        When['ClientScripts.Test.Integration.OnTheAppPage'].iPressTheHomeButton();

        //Assertions
        Then['ClientScripts.Test.Integration.OnTheHomePage'].iShouldSeeTheHomeView();
    });
});
