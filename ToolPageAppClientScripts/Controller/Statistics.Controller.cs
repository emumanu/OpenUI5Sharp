using Bridge;
using System;
using System.Linq;
using UI5;
using System.Collections.Generic;

namespace ClientScripts
{
    [FileName("controller/Statistics.controller.js")]
    [Name("manu.toolpageapp.fv.controller.Statistics")]
    public class StatisticsController : BaseController
    {
        public object formatter;

        [Init(InitPosition.Top)]
        public static void RequireScript()
        {
            jQuery.sap.require("manu/toolpageapp/fv/controller/BaseController");
        }

        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "sap/ui/model/json/JSONModel",
                },
                new Func<object, object>(
                    (Formatter) => {
                        StatisticsController newObj = Glue.CreateRawClassObject<StatisticsController>();
                        newObj.formatter = Formatter;
                        return BaseController.extend(nameof(StatisticsController), newObj);
                    }
                )
            );
        }

        public StatisticsController(Union<string, object[]> sName) : base(sName)
        {
        }

        public override void onInit()
        {
            // TODO: change for StErMi/openui5-chartjs
            var oViewModel = new sap.ui.model.json.JSONModel(new ChartData() {
                ColumnChartData = new V[] { new V() { v = 80 }, new V() { v = 150 }, new V() { v = 400 }, new V() { v = 200 } },
				ColumnChartData2 = new V[] { new V() { v = 40 }, new V() { v = 320 }, new V() { v = 270 }, new V() { v = 140 }, new V() { v = 60 } },
				ComparisonChartData = new V[] { new V() { v = 120}, new V() { v = -67}, new V() { v = 250}, new V() { v = -80} },
				ComparisonChartData2 = new V[] { new V() { v = -70 }, new V() { v = 170 }, new V() { v = -30 }, new V() { v = 60 }, new V() { v = 120 } },
				PieChartData = new V[] { new V() { v = 83 } },
				PieChartData2 = new V[] { new V() { v = 57 } }
			});

            this.setModel(oViewModel, "view");

			this.byId<sap.m.Panel>("statisticsContainer").addContent(sap.ui.xmlview(new sap.ui.ViewInfo() {
                id = this.getView().createId("charts"),
                viewName = "manu.toolpageapp.fv.view.StatisticsD3"
            }));
        }

        public void onRefresh(sap.ui.@base.Event oEvent, object oData)
        {
            sap.ui.layout.BlockLayout blockLayout = this.byId<sap.ui.core.mvc.View>("charts").byId<sap.ui.layout.BlockLayout>("statisticsBlockLayout");

            blockLayout.invalidate();
            blockLayout.setBusy(true);
            Retyped.dom.setTimeout((objs) => {
                blockLayout.setBusy(false);
            }, 2000);
        }
    }
}