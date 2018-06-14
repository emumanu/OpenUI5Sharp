jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
jQuery.sap.require("sap/ui/model/Filter");
jQuery.sap.require("sap/ui/model/FilterOperator");
jQuery.sap.require("sap/ui/model/Sorter");

jQuery.sap.declare({ modName: "sap.ui.demo.nav.controller.employee.Employee", type: "controller" });

Bridge.assembly("RoutingClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("sap.ui.demo.nav.controller.employee.overview.EmployeeOverviewContent", {
        inherits: [sap.ui.demo.nav.controller.BaseController],
        $metadata : function () { return {"nested":[System.Object],"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.String],"pi":[{"n":"sName","pt":System.String,"ps":0}],"sn":"ctor"},{"a":2,"n":"ScriptTop","is":true,"t":8,"sn":"ScriptTop","rt":System.Void},{"a":2,"n":"_applySearchFilter","t":8,"pi":[{"n":"sSearchQuery","pt":System.String,"ps":0}],"sn":"_applySearchFilter","rt":System.Void,"p":[System.String]},{"a":2,"n":"_applySorter","t":8,"pi":[{"n":"sSortField","pt":System.String,"ps":0},{"n":"sortDescending","dv":false,"o":true,"pt":System.Boolean,"ps":1}],"sn":"_applySorter","rt":System.Void,"p":[System.String,System.Boolean]},{"a":2,"n":"_initViewSettingsDialog","t":8,"sn":"_initViewSettingsDialog","rt":System.Void},{"a":2,"n":"_onRouteMatched","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"_onRouteMatched","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"_syncViewSettingsDialogSorter","t":8,"pi":[{"n":"sSortField","pt":System.String,"ps":0},{"n":"bSortDescending","pt":System.Boolean,"ps":1}],"sn":"_syncViewSettingsDialogSorter","rt":System.Void,"p":[System.String,System.Boolean]},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"a":2,"n":"onItemPressed","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onItemPressed","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"onSearchEmployeesTable","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onSearchEmployeesTable","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"onSortButtonPressed","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onSortButtonPressed","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"_aValidSortFields","t":4,"rt":System.Array.type(System.String),"sn":"_aValidSortFields"},{"a":2,"n":"_bSortDescending","t":4,"rt":System.Boolean,"sn":"_bSortDescending","box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":2,"n":"_oRouterArgs","t":4,"rt":System.Object,"sn":"_oRouterArgs"},{"a":2,"n":"_oTable","t":4,"rt":sap.m.Table,"sn":"_oTable"},{"a":2,"n":"_oVSD","t":4,"rt":sap.m.ViewSettingsDialog,"sn":"_oVSD"},{"a":2,"n":"_sSearchQuery","t":4,"rt":System.String,"sn":"_sSearchQuery"},{"a":2,"n":"_sSortField","t":4,"rt":System.String,"sn":"_sSortField"}]}; },
        fields: {
            _oTable: null,
            _oVSD: null,
            _sSortField: null,
            _bSortDescending: false,
            _aValidSortFields: null,
            _sSearchQuery: null,
            _oRouterArgs: null
        },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                sap.ui.demo.nav.controller.BaseController.ctor.call(this, sName);
            }
        },
        methods: {
            onInit: function () {
                var oRouter = this.getRouter();
                this._oTable = this.byId("employeesTable");
                this._oVSD = null;
                this._sSortField = null;
                this._bSortDescending = false;
                this._aValidSortFields = System.Array.init(["EmployeeID", "FirstName", "LastName"], System.String);
                this._sSearchQuery = null;
                this._oRouterArgs = null;
                this._initViewSettingsDialog();
                // make the search bookmarkable
                oRouter.getRoute("employeeOverview").attachMatched(Bridge.fn.cacheBind(this, this._onRouteMatched));
            },
            _onRouteMatched: function (oEvent, oData) {
                var $t, $t1, $t2;
                // save the current query state
                var oRouterArgs = sapuibaseExtensions.getParameterFor(Bridge.global.System.Object, System.Object, oEvent, ($t = { ntype: 38, t: System.Object, n: "p" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"arguments","t":4,"rt":System.Object,"sn":"arguments"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })));
                this._oRouterArgs = oRouterArgs["?query"] || { };
                if (this._oRouterArgs != null) {
                    // convert string to boolean
                    this._oRouterArgs.sortDescending = Glue.ToBoolean(this._oRouterArgs.sortDescending);
                    this._oRouterArgs.showDialog = Glue.ToBoolean(this._oRouterArgs.showDialog);

                    // search/filter via URL hash
                    this._applySearchFilter(this._oRouterArgs.search);
                    // sorting via URL hash
                    this._applySorter(this._oRouterArgs.sortField, this._oRouterArgs.sortDescending);
                    // show dialog via URL hash
                    if (this._oRouterArgs.showDialog) {
                        this._oVSD.open();
                    }
                }
            },
            onSortButtonPressed: function (oEvent, oData) {
                var oRouter = this.getRouter();
                this._oRouterArgs.showDialog = true;
                oRouter.navTo("employeeOverview", { query: this._oRouterArgs });
            },
            onSearchEmployeesTable: function (oEvent, oData) {
                var oRouter = this.getRouter();
                // update the hash with the current search term
                this._oRouterArgs.search = oEvent.getSource().getValue();
                oRouter.navTo("employeeOverview", { query: this._oRouterArgs }, true);
            },
            _initViewSettingsDialog: function () {
                var cancelFunction = null;
                var confirmFunction = null;
                var oRouter = this.getRouter();




                confirmFunction = Bridge.fn.bind(this, function (oEvent, oData) {
                    var $t, $t1, $t2, $t3, $t4, $t5;
                    var oSortItem = sapuibaseExtensions.getParameterFor(Bridge.global.System.Object, Bridge.global.sap.m.ViewSettingsItem, oEvent, ($t = { ntype: 38, t: System.Object, n: "e" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"sortItem","t":4,"rt":sap.m.ViewSettingsItem,"sn":"sortItem"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })));
                    this._oRouterArgs.sortField = oSortItem.getKey();
                    this._oRouterArgs.sortDescending = sapuibaseExtensions.getParameterFor(Bridge.global.System.Object, System.Boolean, oEvent, ($t3 = { ntype: 38, t: System.Object, n: "e" }, ($t5 = ($t4 = {"td":System.Object,"a":2,"n":"sortDescending","t":4,"rt":System.Boolean,"sn":"sortDescending","box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}}, { ntype: 23, t: $t4.rt, expression: $t3, member: $t4 }), { ntype: 18, t: Function, rt: $t5.t, body: $t5, p: Bridge.toList([$t3]) })));
                    this._oRouterArgs.showDialog = false;
                    oRouter.navTo("employeeOverview", { query: this._oRouterArgs }, true);
                });
                cancelFunction = Bridge.fn.bind(this, function (oEvent, oData) {
                    this._oRouterArgs.showDialog = false;
                    oRouter.navTo("employeeOverview", { query: this._oRouterArgs }, true);
                });

                this._oVSD = new sap.m.ViewSettingsDialog("vsd", { confirm: confirmFunction, cancel: cancelFunction });
                // init sorting (with simple sorters as custom data for all fields)
                this._oVSD.addSortItem(new sap.m.ViewSettingsItem({ key: "EmployeeID", text: "Employee ID", selected: true }));

                this._oVSD.addSortItem(new sap.m.ViewSettingsItem({ key: "FirstName", text: "First Name", selected: false }));

                this._oVSD.addSortItem(new sap.m.ViewSettingsItem({ key: "LastName", text: "Last Name", selected: false }));
            },
            _applySearchFilter: function (sSearchQuery) {
                var oFilter;

                // first check if we already have this search value
                if (Bridge.referenceEquals(this._sSearchQuery, sSearchQuery)) {
                    return;
                }
                this._sSearchQuery = sSearchQuery;
                this.byId("searchField").setValue(sSearchQuery);
                // add filters for search
                var aFilters = new (System.Collections.Generic.List$1(sap.ui.model.Filter)).ctor();
                if ((sSearchQuery != null) && (sSearchQuery.length > 0)) {
                    aFilters.add(new sap.ui.model.Filter("FirstName", sap.ui.model.FilterOperator.Contains, sSearchQuery));
                    aFilters.add(new sap.ui.model.Filter("LastName", sap.ui.model.FilterOperator.Contains, sSearchQuery));
                    oFilter = new sap.ui.model.Filter({ filters: aFilters.ToArray(), and: false }); // OR filter
                } else {
                    oFilter = null;
                }
                // update list binding
                var oBinding = this._oTable.getBinding("items");
                oBinding.filter(oFilter, sap.ui.model.FilterType.Application);
            },
            _applySorter: function (sSortField, sortDescending) {
                if (sortDescending === void 0) { sortDescending = false; }
                // only continue if we have a valid sort field
                if ((sSortField != null) && System.Array.contains(this._aValidSortFields, sSortField, System.String)) {
                    // sort only if the sorter has changed
                    if ((this._sSortField != null) && (Bridge.referenceEquals(this._sSortField, sSortField)) && (this._bSortDescending === sortDescending)) {
                        return;
                    }
                    this._sSortField = sSortField;
                    this._bSortDescending = sortDescending;
                    var oSorter = new sap.ui.model.Sorter(sSortField, sortDescending);
                    // sync with View Settings Dialog
                    this._syncViewSettingsDialogSorter(sSortField, sortDescending);
                    var oBinding = this._oTable.getBinding("items");
                    oBinding.sort(oSorter);
                }
            },
            _syncViewSettingsDialogSorter: function (sSortField, bSortDescending) {
                // the possible keys are: "EmployeeID" | "FirstName" | "LastName"
                // Note: no input validation is implemented here 
                this._oVSD.setSelectedSortItem(sSortField);
                this._oVSD.setSortDescending(bSortDescending);
            },
            onItemPressed: function (oEvent, oData) {
                var oItem = oEvent.getParameter("listItem");
                var oCtx = oItem.getBindingContext();
                this.getRouter().navTo("employeeResume", { employeeId: oCtx.getProperty("EmployeeID"), query: { tab: "Info" } });
            }
        }
    });
});
