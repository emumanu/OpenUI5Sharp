jQuery.sap.require("manu/toolpageapp/fv/controller/BaseController");

Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("manu.toolpageapp.fv.controller.settings.MasterSettings", {
        inherits: [manu.toolpageapp.fv.controller.BaseController],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[System.Object],"pi":[{"n":"sName","pt":System.Object,"ps":0}],"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"a":2,"n":"RequireScript","is":true,"t":8,"sn":"RequireScript","rt":System.Void},{"v":true,"a":2,"n":"onCancelPressed","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onCancelPressed","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"v":true,"a":2,"n":"onMasterPressed","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onMasterPressed","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"v":true,"a":2,"n":"onNavButtonPress","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onNavButtonPress","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"v":true,"a":2,"n":"onSavePressed","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onSavePressed","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"formatter","t":4,"rt":System.Object,"sn":"formatter"}]}; },
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
                var oViewModel = new sap.ui.model.json.JSONModel({ currenUser: "Administrator", lastLogin: System.DateTime.addDays(System.DateTime.getNow(), -1) });
                this.setModel(oViewModel, "view");
            },
            onMasterPressed: function (oEvent, oData) {
                var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7, $t8;
                var oContext = oEvent.getParameter("listItem").getBindingContext("side");
                sapuimodelModelExtensions.setPropertyFor$1(System.Object, System.Boolean, oContext.getModel(), ($t = { ntype: 38, t: System.Object, n: "p" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"selected","t":16,"rt":System.Boolean,"g":{"td":System.Object,"a":2,"n":"get_selected","t":8,"rt":System.Boolean,"fg":"selected","box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},"s":{"td":System.Object,"a":2,"n":"set_selected","t":8,"p":[System.Boolean],"rt":System.Void,"fs":"selected"},"fn":"selected"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })), true, oContext, false);
                var sSelectedMasterElement = sapuimodelContextExtensions.getPropertyFor(System.Object, System.String, oContext, ($t3 = { ntype: 38, t: System.Object, n: "p" }, ($t5 = ($t4 = {"td":System.Object,"a":2,"n":"title","t":16,"rt":System.String,"g":{"td":System.Object,"a":2,"n":"get_title","t":8,"rt":System.String,"fg":"title"},"s":{"td":System.Object,"a":2,"n":"set_title","t":8,"p":[System.String],"rt":System.Void,"fs":"title"},"fn":"title"}, { ntype: 23, t: $t4.rt, expression: $t3, member: $t4 }), { ntype: 18, t: Function, rt: $t5.t, body: $t5, p: Bridge.toList([$t3]) })), false);
                var sKey = sapuimodelContextExtensions.getPropertyFor(System.Object, System.String, oContext, ($t6 = { ntype: 38, t: System.Object, n: "p" }, ($t8 = ($t7 = {"td":System.Object,"a":2,"n":"key","t":16,"rt":System.String,"g":{"td":System.Object,"a":2,"n":"get_key","t":8,"rt":System.String,"fg":"key"},"s":{"td":System.Object,"a":2,"n":"set_key","t":8,"p":[System.String],"rt":System.Void,"fs":"key"},"fn":"key"}, { ntype: 23, t: $t7.rt, expression: $t6, member: $t7 }), { ntype: 18, t: Function, rt: $t8.t, body: $t8, p: Bridge.toList([$t6]) })), false);
                switch (sSelectedMasterElement) {
                    case "System Settings": 
                        {
                            this.getRouter().navTo(sKey);
                            break;
                        }
                    default: 
                        {
                            sap.m.MessageToast.show((sSelectedMasterElement || "") + " was pressed");
                            break;
                        }
                }
            },
            onSavePressed: function (oEvent, oData) {
                sap.m.MessageToast.show("Save was pressed");
            },
            onCancelPressed: function (oEvent, oData) {
                sap.m.MessageToast.show("Cancel was pressed");
            },
            onNavButtonPress: function (oEvent, oData) {
                this.getOwnerComponent().myNavBack();
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/m/MessageToast", "sap/ui/model/json/JSONModel"], System.String), function (Formatter) {
    var newObj = UI5.Glue.CreateRawClassObject(manu.toolpageapp.fv.controller.settings.MasterSettings);
    return sap.ui.core.mvc.Controller.extend("manu.toolpageapp.fv.controller.settings.MasterSettings", newObj);
});
