jQuery.sap.require("manu/toolpageapp/fv/controller/BaseController");

Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("manu.toolpageapp.fv.controller.Statistics", {
        inherits: [manu.toolpageapp.fv.controller.BaseController],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.Object],"pi":[{"n":"sName","pt":System.Object,"ps":0}],"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"a":2,"n":"RequireScript","is":true,"t":8,"sn":"RequireScript","rt":System.Void},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"a":2,"n":"onRefresh","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onRefresh","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"formatter","t":4,"rt":System.Object,"sn":"formatter"}]}; },
        fields: {
            formatter: null
        },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                manu.toolpageapp.fv.controller.BaseController.ctor.call(this, sName);
            }
        },
        methods: {
            onInit: function () {
                // TODO: change for StErMi/openui5-chartjs
                var oViewModel = new sap.ui.model.json.JSONModel({ ColumnChartData: System.Array.init([{ v: 80 }, { v: 150 }, { v: 400 }, { v: 200 }], System.Object), ColumnChartData2: System.Array.init([{ v: 40 }, { v: 320 }, { v: 270 }, { v: 140 }, { v: 60 }], System.Object), ComparisonChartData: System.Array.init([{ v: 120 }, { v: -67 }, { v: 250 }, { v: -80 }], System.Object), ComparisonChartData2: System.Array.init([{ v: -70 }, { v: 170 }, { v: -30 }, { v: 60 }, { v: 120 }], System.Object), PieChartData: System.Array.init([{ v: 83 }], System.Object), PieChartData2: System.Array.init([{ v: 57 }], System.Object) });

                this.setModel(oViewModel, "view");

                this.byId("statisticsContainer").addContent(sap.ui.xmlview({ id: this.getView().createId("charts"), viewName: "manu.toolpageapp.fv.view.StatisticsD3" }));
            },
            onRefresh: function (oEvent, oData) {
                var blockLayout = this.byId("charts").byId("statisticsBlockLayout");

                blockLayout.invalidate();
                blockLayout.setBusy(true);
                setTimeout(function (objs) {
                    blockLayout.setBusy(false);
                }, 2000);
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/model/json/JSONModel"], System.String), function (Formatter) {
    var newObj = UI5.Glue.CreateRawClassObject(manu.toolpageapp.fv.controller.Statistics);
    newObj.formatter = Formatter;
    return sap.ui.core.mvc.Controller.extend("manu.toolpageapp.fv.controller.Statistics", newObj);
});
