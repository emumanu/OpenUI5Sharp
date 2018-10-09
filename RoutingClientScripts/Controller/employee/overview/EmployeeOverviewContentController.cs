using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using UI5;
using UI5.Extensions;

namespace RoutingClientScripts
{
    [FileName("controller/employee/overview/EmployeeOverviewContent.controller.js")]
    [Name("sap.ui.demo.nav.controller.employee.overview.EmployeeOverviewContent")]
    public class EmployeeOverviewContentController : BaseController
    {
        [Init(InitPosition.Top)]
        public static void ScriptTop()
        {
            jQuery.sap.require("sap/ui/demo/nav/controller/BaseController");
            jQuery.sap.require("sap/ui/model/Filter");
            jQuery.sap.require("sap/ui/model/FilterOperator");
            jQuery.sap.require("sap/ui/model/Sorter");

            jQuery.sap.declare(new { modName = nameof(EmployeeController), type = "controller" });
        }

        [ObjectLiteral]
        public class SearchParameters
        {
            public string search;
            public string sortField;
            public bool sortDescending;
            public bool showDialog;
        }

        public EmployeeOverviewContentController(string sName) : base(sName)
        {
        }

        public sap.m.Table _oTable;
        public sap.m.ViewSettingsDialog _oVSD;
        public string _sSortField;
        public bool _bSortDescending;
        public string[] _aValidSortFields;
        public string _sSearchQuery;
        public SearchParameters _oRouterArgs;

        public override void onInit()
        {
            sap.ui.core.routing.Router oRouter = this.getRouter();
            this._oTable = this.byId<sap.m.Table>("employeesTable");
            this._oVSD = null;
            this._sSortField = null;
            this._bSortDescending = false;
            this._aValidSortFields = new string[] { "EmployeeID", "FirstName", "LastName" };
            this._sSearchQuery = null;
            this._oRouterArgs = null;
            this._initViewSettingsDialog();
            // make the search bookmarkable
            oRouter.getRoute("employeeOverview").attachMatched(_onRouteMatched);
        }

        public void _onRouteMatched(sap.ui.@base.Event<sap.ui.core.routing.Route.MatchedInfo> oEvent, object oData)
        {
            // save the current query state
            var oRouterArgs = oEvent.getParameterFor(p => p.arguments);
            this._oRouterArgs = oRouterArgs["?query"].As<SearchParameters>() ?? new SearchParameters();
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
        }

        public void onSortButtonPressed(sap.ui.@base.Event oEvent, object oData)
        {
            var oRouter = this.getRouter();
            this._oRouterArgs.showDialog = true;
            oRouter.navTo("employeeOverview", new { query = this._oRouterArgs });
        }

        public void onSearchEmployeesTable(sap.ui.@base.Event oEvent, object oData)
        {
            var oRouter = this.getRouter();
            // update the hash with the current search term
            this._oRouterArgs.search = oEvent.getSource<sap.m.SearchField>().getValue();
            oRouter.navTo("employeeOverview", new { query = this._oRouterArgs }, true /*no history*/);
        }

        public void _initViewSettingsDialog()
        {
            var oRouter = this.getRouter();

            void confirmFunction(sap.ui.@base.Event<sap.m.ViewSettingsDialog.ConfirmInfo> oEvent, object oData)
            {
                var oSortItem = oEvent.getParameterFor(e => e.sortItem);
                this._oRouterArgs.sortField = oSortItem.getKey();
                this._oRouterArgs.sortDescending = oEvent.getParameterFor(e => e.sortDescending);
                this._oRouterArgs.showDialog = false;
                oRouter.navTo("employeeOverview", new { query = this._oRouterArgs }, true /*without history*/);
            }

            void cancelFunction(sap.ui.@base.Event oEvent, object oData)
            {
                this._oRouterArgs.showDialog = false;
                oRouter.navTo("employeeOverview", new { query = this._oRouterArgs }, true /*without history*/);
            }
            
            this._oVSD = new sap.m.ViewSettingsDialog("vsd", new sap.m.ViewSettingsDialog.Settings {
                confirm = confirmFunction,
                cancel = cancelFunction
            });
            // init sorting (with simple sorters as custom data for all fields)
            this._oVSD.addSortItem(new sap.m.ViewSettingsItem(new sap.m.ViewSettingsItem.Settings {
				key = "EmployeeID",
				text = "Employee ID",
				selected = true		 // we do this because our MockData is sorted anyway by EmployeeID
			}));

            this._oVSD.addSortItem(new sap.m.ViewSettingsItem(new sap.m.ViewSettingsItem.Settings {
				key = "FirstName",
				text = "First Name",
				selected = false
			}));

            this._oVSD.addSortItem(new sap.m.ViewSettingsItem(new sap.m.ViewSettingsItem.Settings {
				key = "LastName",
				text = "Last Name",
				selected = false
			}));
		}
		public void _applySearchFilter(string sSearchQuery)
        {
            sap.ui.model.Filter oFilter;

            // first check if we already have this search value
            if (this._sSearchQuery == sSearchQuery) {
                return;
            }
            this._sSearchQuery = sSearchQuery;
            this.byId<sap.m.SearchField>("searchField").setValue(sSearchQuery);
            // add filters for search
            var aFilters = new List<sap.ui.model.Filter>();
            if ((sSearchQuery != null) && (sSearchQuery.Length > 0)) {
                aFilters.Add(new sap.ui.model.Filter("FirstName", sap.ui.model.FilterOperator.Contains, sSearchQuery));
                aFilters.Add(new sap.ui.model.Filter("LastName", sap.ui.model.FilterOperator.Contains, sSearchQuery));
                oFilter = new sap.ui.model.Filter(new sap.ui.model.Filter.FilterInfo() { filters = aFilters.ToArray(), and = false });  // OR filter
            } else {
                oFilter = null;
            }
            // update list binding
            var oBinding = this._oTable.getBinding<sap.ui.model.odata.v4.ODataListBinding>("items");
            oBinding.filter(oFilter, sap.ui.model.FilterType.Application);
        }

        /**
		 * Applies sorting on our table control.
		 * @param {string} sSortField	  the name of the field used for sorting
		 * @param {string} sortDescending  true or false as a string or boolean value to specify a descending sorting
		 * @private
		 */
        public void _applySorter(string sSortField, bool sortDescending = false)
        {
            // only continue if we have a valid sort field
            if ((sSortField != null) && this._aValidSortFields.Contains(sSortField)) {
                // sort only if the sorter has changed
                if ((_sSortField != null) && (this._sSortField == sSortField) && (this._bSortDescending == sortDescending)) {
                    return;
                }
                this._sSortField = sSortField;
                this._bSortDescending = sortDescending;
                var oSorter = new sap.ui.model.Sorter(sSortField, sortDescending);
                // sync with View Settings Dialog
                this._syncViewSettingsDialogSorter(sSortField, sortDescending);
                var oBinding = this._oTable.getBinding<sap.ui.model.odata.v4.ODataListBinding>("items");
                oBinding.sort(oSorter);
            }
        }
		public void _syncViewSettingsDialogSorter(string sSortField, bool bSortDescending)
        {
            // the possible keys are: "EmployeeID" | "FirstName" | "LastName"
            // Note: no input validation is implemented here 
            this._oVSD.setSelectedSortItem(sSortField);
            this._oVSD.setSortDescending(bSortDescending);
        }

        public void onItemPressed(sap.ui.@base.Event oEvent, object oData)
        {
            var oItem = oEvent.getParameter<sap.m.ListItemBase>("listItem");
            var oCtx = oItem.getBindingContext<sap.ui.model.odata.v4.Context>();
            this.getRouter().navTo("employeeResume", new {
                employeeId = oCtx.getProperty("EmployeeID"),
				query = new {
                    tab = "Info"
                }
            });
        }
    }
}
