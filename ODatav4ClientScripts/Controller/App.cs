using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;

namespace ODatav4ClientScripts
{
    [FileName("controller/App.controller.js")]
    [Name("sap.ui.core.tutorial.odatav4.controller.App")]
    public class App : sap.ui.core.mvc.Controller
    {
        [ObjectLiteral]
        public class ViewModel
        {
            public bool busy;
            public bool hasUIChanges;
            public bool usernameEmpty;
            public int order;
        }

        protected bool _bTechnicalErrors;

        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.define(new string[] {
                    "sap/ui/core/mvc/Controller",
                    "sap/m/MessageToast",
                    "sap/m/MessageBox",
                    "sap/ui/model/Sorter",
                    "sap/ui/model/Filter",
                    "sap/ui/model/FilterOperator",
                    "sap/ui/model/FilterType",
                    "sap/ui/model/json/JSONModel"
                },
                new Func<object>(
                    () => {
                        var newObj = Glue.CreateRawClassObject<App>();
                        return sap.ui.core.mvc.Controller.extend(nameof(App), newObj);
                    }
                )
            );
        }

        public App(string sName) : base(sName)
        {
        }

        public override void onInit()
        {
            var oMessageManager = sap.ui.getCore().getMessageManager();
            var oMessageModel = oMessageManager.getMessageModel();
            var oMessageModelBinding = oMessageModel.bindList(
                "/",
                null,
                new sap.ui.model.Sorter[] { },
                new sap.ui.model.Filter("technical", (Union<sap.ui.model.FilterOperator, object, bool>)sap.ui.model.FilterOperator.EQ, true));
            var oViewModel = new sap.ui.model.json.JSONModel(new ViewModel() {
                busy = false,
                hasUIChanges = false,
                usernameEmpty = true,
                order = 0
            });
            this.getView().setModel(oViewModel, "appView");
            this.getView().setModel(oMessageModel, "message");

            oMessageModelBinding.attachChange(onMessageBindingChange);
            this._bTechnicalErrors = false;
        }

        public bool onCreate()
        {
            var oList = this.byId<sap.m.Table>("peopleList");
            var oBinding = oList.getBinding<sap.ui.model.odata.v4.ODataListBinding>("items");
            var oContext = oBinding.create(new People() {
                UserName = "",
                FirstName = "",
                LastName = "",
                Age = 18
            });

            oContext.created().then((value) => oBinding.refresh());

            this._setUIChanges();
            this.getView().getModelFor<ViewModel>("appView").setPropertyFor(m => m.usernameEmpty, true);

            return oList.getItems().Any((oItem) => {
                if (oItem.getBindingContext() == oContext) {
                    oItem.focus();
                    oItem.setSelected(true);
                    return true;
                }

                return false;
            });
        }

        public object fnDeleteSucces(object value)
        {
            sap.m.MessageToast.show(this._getText("deletionSuccessMessage"));

            return null;
        }

        public object fnDeleteError(object oError)
        {
            sap.m.MessageBox.error(oError["message"].ToString());

            return null;
        }

        public void onDelete()
        {
            var oSelected = this.byId<sap.m.Table>("peopleList").getSelectedItem();

            if (oSelected != null) {
                oSelected.getBindingContext<sap.ui.model.odata.v4.Context>().delete("$auto").then(fnDeleteSucces, fnDeleteError);
            }
        }

        public void onInputChange(sap.ui.@base.Event oEvt)
        {
            if (oEvt.getParameter<bool>("escPressed")) {
                this._setUIChanges(null);
            } else {
                this._setUIChanges(true);
                if (oEvt.getSource<sap.m.Input>().getParent().getBindingContext().For<People>().getPropertyFor(m => m.UserName, false) != null) {
                    this.getView().getModelFor<ViewModel>("appView").setPropertyFor(m => m.usernameEmpty, false);
                }
            }
        }

        public void onRefresh()
        {
            var oBinding = this.byId("peopleList").getBinding<sap.ui.model.odata.v4.ODataListBinding>("items");

            if (oBinding.hasPendingChanges()) {
                sap.m.MessageBox.error(this._getText("refreshNotPossibleMessage"));
                return;
            }
            oBinding.refresh();
            sap.m.MessageToast.show(this._getText("refreshSuccessMessage"));
        }
        public void onResetChanges()
        {
            this.byId("peopleList").getBinding<sap.ui.model.odata.v4.ODataListBinding>("items").resetChanges();
            this._bTechnicalErrors = false;
            this._setUIChanges(null);
        }

        public object fnResetDataSourceSucces(object value)
        {
            var oModel = this.getView().getModel<sap.ui.model.odata.v4.ODataModel>();
            oModel.refresh();
            sap.m.MessageToast.show(this._getText("sourceResetSuccessMessage"));

            return null;
        }

        public object fnResetDataSourceError(object oError)
        {
            sap.m.MessageBox.error(oError["message"].ToString());

            return null;
        }

        public void onResetDataSource()
        {
            var oModel = this.getView().getModel<sap.ui.model.odata.v4.ODataModel>();
            var oOperation = oModel.bindContext("/ResetDataSource(...)");

            oOperation.execute().then(fnResetDataSourceSucces, fnResetDataSourceError);
        }

        public void onSave()
        {
            object fnSaveSucces(object value)
            {
                this._setBusy(false);
                sap.m.MessageToast.show(this._getText("changesSentMessage"));
                this._setUIChanges(false);

                return null;
            }

            object fnSaveError(object oError)
            {
                this._setBusy(false);
                this._setUIChanges(false);
                sap.m.MessageBox.error(oError["message"].ToString());

                return null;
            }

            this._setBusy(true); // Lock UI until submitBatch is resolved.
            this.getView().getModel<sap.ui.model.odata.v4.ODataModel>().submitBatch("peopleGroup").then(fnSaveSucces, fnSaveError);
            this._bTechnicalErrors = false; // If there were technical errors, a new save resets them.
        }

        public void onSearch()
        {
            var oView = this.getView();
            var sValue = oView.byId<sap.m.SearchField>("searchField").getValue();
            var oFilter = new sap.ui.model.Filter("LastName", sap.ui.model.FilterOperator.Contains, sValue);

            oView.byId<sap.m.Table>("peopleList").getBinding<sap.ui.model.odata.v4.ODataListBinding>("items").filter(oFilter, sap.ui.model.FilterType.Application);
        }

        public void onSort()
        {
            var oView = this.getView();
            string[] aStates = new string[] { null, "asc", "desc" };
            string[] aStateTextIds = new string[] { "sortNone", "sortAscending", "sortDescending" };
            string sMessage;
            int iOrder = oView.getModelFor<ViewModel>("appView").getPropertyFor(m => m.order);

            iOrder = (iOrder + 1) % aStates.Length;
            var sOrder = aStates[iOrder];

            oView.getModelFor<ViewModel>("appView").setPropertyFor(m => m.order, iOrder);
            if (sOrder != null) {
                oView.byId("peopleList").getBinding<sap.ui.model.odata.v4.ODataListBinding>("items").sort(new sap.ui.model.Sorter("LastName", sOrder == "desc"));
            } else {
                oView.byId("peopleList").getBinding<sap.ui.model.odata.v4.ODataListBinding>("items").sort();
            }

            sMessage = this._getText("sortMessage", new string[] { this._getText(aStateTextIds[iOrder]) });
            sap.m.MessageToast.show(sMessage);
        }
        
        public void onMessageBindingChange(sap.ui.@base.Event<sap.ui.model.Binding.ChangeInfo> oEvent, object oData)
        {
            var aContexts = oEvent.getSource<sap.ui.model.ListBinding>().getContexts();
            sap.ui.core.message.Message[] aMessages;
            bool bMessageOpen = false;

            if (bMessageOpen || (aContexts.Length == 0)) {
                return;
            }

            // Extract and remove the technical messages
            aMessages = aContexts.Select(oContext => oContext.getObject<sap.ui.core.message.Message>()).ToArray();
            sap.ui.getCore().getMessageManager().removeMessages(aMessages);

            this._setUIChanges(true);
            this._bTechnicalErrors = true;

            sap.m.MessageBox.error(aMessages[0].getMessage(), new sap.m.MessageBox.NotifyOptions {
                id = "serviceErrorMessageBox",
                onClose = (Action)(() => bMessageOpen = false)
            });

            bMessageOpen = true;
        }

        public string _getText(string sTextId, string[] aArgs = null)
        {
            return ((jQuery.sap.util.ResourceBundle)this.getOwnerComponent<Component>().getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle()).getText(sTextId, aArgs);
        }

        public void _setUIChanges(bool? bHasUIChanges = null)
        {
            if (this._bTechnicalErrors) {
                // If there is currently a technical error, then force 'true'.
                bHasUIChanges = true;
            } else if (bHasUIChanges == null) {
                // if it is not specified, get it from the model
                bHasUIChanges = this.getView().getModel<sap.ui.model.odata.v4.ODataModel>().hasPendingChanges();
            }
            var oModel = this.getView().getModelFor<ViewModel>("appView");
            oModel.setPropertyFor(m => m.hasUIChanges, bHasUIChanges);
        }

        public void _setBusy(bool bIsBusy)
        {
            var oModel = this.getView().getModelFor<ViewModel>("appView");
            oModel.setProperty("/busy", bIsBusy);
            oModel.setPropertyFor(m => m.busy, bIsBusy);
        }
    }
}
