jQuery.sap.require("manu/toolpageapp/fv/controller/BaseController");

Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("manu.toolpageapp.fv.controller.App", {
        inherits: [manu.toolpageapp.fv.controller.BaseController],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":1,"n":".ctor","t":1,"p":[System.Object],"pi":[{"n":"sName","pt":System.Object,"ps":0}],"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"a":2,"n":"RequireScript","is":true,"t":8,"sn":"RequireScript","rt":System.Void},{"a":2,"n":"_createError","t":8,"pi":[{"n":"sId","pt":System.String,"ps":0},{"n":"oBindingContext","pt":sap.ui.model.Context,"ps":1}],"sn":"_createError","rt":sap.ui.core.Element,"p":[System.String,sap.ui.model.Context]},{"a":2,"n":"_createNotification","t":8,"pi":[{"n":"sId","pt":System.String,"ps":0},{"n":"oBindingContext","pt":sap.ui.model.Context,"ps":1}],"sn":"_createNotification","rt":sap.ui.core.Element,"p":[System.String,sap.ui.model.Context]},{"a":2,"n":"_setToggleButtonTooltip","t":8,"pi":[{"n":"bSideExpanded","pt":System.Boolean,"ps":0}],"sn":"_setToggleButtonTooltip","rt":System.Void,"p":[System.Boolean]},{"ov":true,"a":2,"n":"onInit","t":8,"sn":"onInit","rt":System.Void},{"a":2,"n":"onItemSelect","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onItemSelect","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"onMessagePopoverPress","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onMessagePopoverPress","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"onNotificationPress","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onNotificationPress","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"onSideNavButtonPress","t":8,"pi":[{"n":"oEvent","dv":null,"o":true,"pt":sap.ui.base.Event,"ps":0},{"n":"oData","dv":null,"o":true,"pt":System.Object,"ps":1}],"sn":"onSideNavButtonPress","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":2,"n":"onUserNamePress","t":8,"pi":[{"n":"oEvent","pt":sap.ui.base.Event,"ps":0},{"n":"oData","pt":System.Object,"ps":1}],"sn":"onUserNamePress","rt":System.Void,"p":[sap.ui.base.Event,System.Object]},{"a":1,"n":"Device","t":4,"rt":sap.ui.Device,"sn":"Device"},{"a":2,"n":"_bExpanded","t":4,"rt":System.Boolean,"sn":"_bExpanded","box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}},{"a":1,"n":"oView","t":4,"rt":sap.ui.core.mvc.View,"sn":"oView"}]}; },
        fields: {
            _bExpanded: false,
            Device: null,
            oView: null
        },
        ctors: {
            ctor: function (sName) {
                this.$initialize();
                manu.toolpageapp.fv.controller.BaseController.ctor.call(this, sName);
            }
        },
        methods: {
            onInit: function () {
                this.oView = this.getView();
                this.oView.addStyleClass(this.getOwnerComponent().getContentDensityClass());

                // if the app starts on desktop devices with small or medium screen size, collapses the side navigation
                if (this.Device.resize.width <= 1024) {
                    this.onSideNavButtonPress();
                }
                this.Device.media.attachHandler(Bridge.fn.bind(this, function (oDevice) {
                    if ((Bridge.referenceEquals(oDevice.name, "Tablet") && this._bExpanded) || (Bridge.referenceEquals(oDevice.name, "Desktop"))) {
                        this.onSideNavButtonPress();
                        // set the _bExpanded to false on tablet devices
                        // extending and collapsing of side navigation should be done when resizing from
                        // desktop to tablet screen sizes)
                        this._bExpanded = (Bridge.referenceEquals(oDevice.name, "Desktop"));
                    }
                }));
            },
            /**
             * Convenience method for accessing the router
             *
             * @instance
             * @public
             * @this manu.toolpageapp.fv.controller.App
             * @memberof manu.toolpageapp.fv.controller.App
             * @param   {sap.ui.base.Event}    oEvent    The item select event
             * @param   {System.Object}        oData     not used
             * @return  {void}
             */
            onItemSelect: function (oEvent, oData) {
                var $t, $t1, $t2;
                var oItem = sapuibaseExtensions.getParameterFor(System.Object, sap.ui.core.Item, oEvent, ($t = { ntype: 38, t: System.Object, n: "p" }, ($t2 = ($t1 = {"td":System.Object,"a":2,"n":"item","t":4,"rt":sap.ui.core.Item,"sn":"item"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), { ntype: 18, t: Function, rt: $t2.t, body: $t2, p: Bridge.toList([$t]) })));
                var sKey = oItem.getKey();
                // if you click on home, settings or statistics button, call the navTo function
                if ((Bridge.referenceEquals(sKey, "home") || Bridge.referenceEquals(sKey, "masterSettings") || Bridge.referenceEquals(sKey, "statistics"))) {
                    // if the device is phone, collaps the navigation side of the app to give more space
                    if (this.Device.system.phone) {
                        this.onSideNavButtonPress();
                    }
                    this.getRouter().navTo(sKey);
                } else {
                    sap.m.MessageToast.show(sKey);
                }
            },
            onUserNamePress: function (oEvent, oData) {
                var fnHandleUserMenuItemPress = null;
                var oBundle = this.getModel(sap.ui.model.resource.ResourceModel, "i18n").getResourceBundle();

                // close message popover
                var oMessagePopover = this.byId("errorMessagePopover");
                if ((oMessagePopover != null) && oMessagePopover.isOpen()) {
                    oMessagePopover.destroy();
                }


                fnHandleUserMenuItemPress = function (oEvt, data) {
                    sap.m.MessageToast.show((oEvt.getSource().getText() || "") + " was pressed");
                };

                var oActionSheet = new sap.m.ActionSheet(this.oView.createId("userMessageActionSheet"), { title: oBundle.getText("userHeaderTitle"), showCancelButton: false, buttons: System.Array.init([new sap.m.Button({ text: "User Settings", type: sap.m.ButtonType.Transparent, press: fnHandleUserMenuItemPress }), new sap.m.Button({ text: "Online Guide", type: sap.m.ButtonType.Transparent, press: fnHandleUserMenuItemPress }), new sap.m.Button({ text: "Feedback", type: sap.m.ButtonType.Transparent, press: fnHandleUserMenuItemPress }), new sap.m.Button({ text: "Help", type: sap.m.ButtonType.Transparent, press: fnHandleUserMenuItemPress }), new sap.m.Button({ text: "Logout", type: sap.m.ButtonType.Transparent, press: fnHandleUserMenuItemPress })], sap.m.Button), afterClose: function (ev, d) {
                    ev.getSource().destroy();
                } });

                // forward compact/cozy style into dialog
                jQuery.sap.syncStyleClass(this.oView.getController().getOwnerComponent().getContentDensityClass(), this.oView, oActionSheet);
                oActionSheet.openBy(oEvent.getSource());
            },
            onSideNavButtonPress: function (oEvent, oData) {
                if (oEvent === void 0) { oEvent = null; }
                if (oData === void 0) { oData = null; }
                var oToolPage = this.byId("app");
                var bSideExpanded = oToolPage.getSideExpanded();
                this._setToggleButtonTooltip(bSideExpanded);
                oToolPage.setSideExpanded(!oToolPage.getSideExpanded());
            },
            _setToggleButtonTooltip: function (bSideExpanded) {
                var oToggleButton = this.byId("sideNavigationToggleButton");
                if (bSideExpanded) {
                    oToggleButton.setTooltip("Large Size Navigation");
                } else {
                    oToggleButton.setTooltip("Small Size Navigation");
                }
            },
            onMessagePopoverPress: function (oEvent, oData) {
                if (this.byId("errorMessagePopover") == null) {
                    var oMessagePopover = new sap.m.MessagePopover(this.oView.createId("errorMessagePopover"), { placement: sap.m.VerticalPlacementType.Bottom, items: { path: "alerts>/alerts/errors", factory: Bridge.fn.cacheBind(this, this._createError) }, afterClose: function (ev, data) {
                        ev.getSource().destroy();
                    } });

                    this.byId("app").addDependent(oMessagePopover);

                    // forward compact/cozy style into dialog
                    jQuery.sap.syncStyleClass(this.oView.getController().getOwnerComponent().getContentDensityClass(), this.oView, oMessagePopover);
                    oMessagePopover.openBy(oEvent.getSource());
                }
            },
            /**
             * Event handler for the notification button
             *
             * @instance
             * @public
             * @this manu.toolpageapp.fv.controller.App
             * @memberof manu.toolpageapp.fv.controller.App
             * @param   {sap.ui.base.Event}    oEvent    the button press event
             * @param   {System.Object}        oData     not used
             * @return  {void}
             */
            onNotificationPress: function (oEvent, oData) {
                var oBundle = this.getModel(sap.ui.model.resource.ResourceModel, "i18n").getResourceBundle();
                // close message popover
                var oMessagePopover = this.byId("errorMessagePopover");
                if ((oMessagePopover != null) && oMessagePopover.isOpen()) {
                    oMessagePopover.destroy();
                }
                var oButton = new sap.m.Button({ text: oBundle.getText("notificationButtonText"), press: (function (oEvt, data) {
                    sap.m.MessageToast.show("Show all Notifications was pressed");
                }) });
                var oNotificationPopover = new sap.m.ResponsivePopover(this.oView.createId("notificationMessagePopover"), { title: oBundle.getText("notificationTitle"), contentWidth: "300px", endButton: oButton, placement: sap.m.PlacementType.Bottom, content: { path: "alerts>/alerts/notifications", factory: Bridge.fn.cacheBind(this, this._createNotification) }, afterClose: function (ev, data) {
                    ev.getSource().destroy();
                } });

                this.byId("app").addDependent(oNotificationPopover);

                // forward compact/cozy style into dialog
                jQuery.sap.syncStyleClass(this.oView.getController().getOwnerComponent().getContentDensityClass(), this.oView, oNotificationPopover);
                oNotificationPopover.openBy(oEvent.getSource());
            },
            /**
             * Factory function for the notification items
             *
             * @instance
             * @public
             * @this manu.toolpageapp.fv.controller.App
             * @memberof manu.toolpageapp.fv.controller.App
             * @param   {string}                  sId                sId The id for the item
             * @param   {sap.ui.model.Context}    oBindingContext    The binding context for the item
             * @return  {sap.ui.core.Element}                        The new notification list item
             */
            _createNotification: function (sId, oBindingContext) {
                var oBindingObject = oBindingContext.getObject();
                var oNotificationItem = new sap.m.NotificationListItem({ title: oBindingObject.title, description: oBindingObject.description, priority: oBindingObject.priority, close: function (oEvent, oData) {
                    var $t, $t1, $t2, $t3, $t4, $t5, $t6, $t7, $t8;
                    var source = oEvent.getSource();
                    var sBindingPath = ($t = source.getCustomData())[0].getValue();
                    var sIndex = System.Linq.Enumerable.from(System.String.split(sBindingPath, [47].map(function (i) {{ return String.fromCharCode(i); }}))).last();
                    var aItems = System.Linq.Enumerable.from(sapuimodelModelExtensions.getPropertyFor(System.Object, System.Array.type(System.Object), source.getModel("alerts"), ($t1 = { ntype: 38, t: System.Object, n: "p" }, ($t4 = ($t3 = {"td":System.Object,"a":2,"n":"notifications","t":16,"rt":System.Array.type(System.Object),"g":{"td":System.Object,"a":2,"n":"get_notifications","t":8,"rt":System.Array.type(System.Object),"fg":"notifications"},"s":{"td":System.Object,"a":2,"n":"set_notifications","t":8,"p":[System.Array.type(System.Object)],"rt":System.Void,"fs":"notifications"},"fn":"notifications"}, { ntype: 23, t: $t3.rt, expression: ($t2 = {"td":System.Object,"a":2,"n":"alerts","t":16,"rt":System.Object,"g":{"td":System.Object,"a":2,"n":"get_alerts","t":8,"rt":System.Object,"fg":"alerts"},"s":{"td":System.Object,"a":2,"n":"set_alerts","t":8,"p":[System.Object],"rt":System.Void,"fs":"alerts"},"fn":"alerts"}, { ntype: 23, t: $t2.rt, expression: $t1, member: $t2 }), member: $t3 }), { ntype: 18, t: Function, rt: $t4.t, body: $t4, p: Bridge.toList([$t1]) })))).toList(System.Object);
                    aItems.RemoveRange(parseInt(sIndex), 1);
                    sapuimodelModelExtensions.setPropertyFor(System.Object, System.Array.type(System.Object), source.getModel("alerts"), ($t5 = { ntype: 38, t: System.Object, n: "p" }, ($t8 = ($t7 = {"td":System.Object,"a":2,"n":"notifications","t":16,"rt":System.Array.type(System.Object),"g":{"td":System.Object,"a":2,"n":"get_notifications","t":8,"rt":System.Array.type(System.Object),"fg":"notifications"},"s":{"td":System.Object,"a":2,"n":"set_notifications","t":8,"p":[System.Array.type(System.Object)],"rt":System.Void,"fs":"notifications"},"fn":"notifications"}, { ntype: 23, t: $t7.rt, expression: ($t6 = {"td":System.Object,"a":2,"n":"alerts","t":16,"rt":System.Object,"g":{"td":System.Object,"a":2,"n":"get_alerts","t":8,"rt":System.Object,"fg":"alerts"},"s":{"td":System.Object,"a":2,"n":"set_alerts","t":8,"p":[System.Object],"rt":System.Void,"fs":"alerts"},"fn":"alerts"}, { ntype: 23, t: $t6.rt, expression: $t5, member: $t6 }), member: $t7 }), { ntype: 18, t: Function, rt: $t8.t, body: $t8, p: Bridge.toList([$t5]) })), aItems.ToArray());
                    source.getModel("alerts").updateBindings(true);
                    sap.m.MessageToast.show("Notification has been deleted.");
                }, datetime: oBindingObject.date, authorPicture: oBindingObject.icon, press: function (oEvent, oData) { }, customData: System.Array.init([new sap.ui.core.CustomData({ key: "path", value: oBindingContext.getPath() })], sap.ui.core.CustomData) });

                return oNotificationItem;
            },
            _createError: function (sId, oBindingContext) {
                var oBindingObject = oBindingContext.getObject();
                var oLink = new sap.m.Link({ text: "More Details", press: function (oEvent, oData) {
                    sap.m.MessageToast.show("More Details was pressed");
                } });

                var oMessageItem = new sap.m.MessagePopoverItem({ title: oBindingObject.title, subtitle: oBindingObject.subTitle, description: oBindingObject.description, counter: oBindingObject.counter, link: oLink });

                return oMessageItem;
            }
        }
    });
});

sap.ui.define(System.Array.init(["sap/ui/Device", "jquery.sap.global", "sap/ui/core/Fragment", "sap/ui/core/mvc/Controller", "sap/ui/model/json/JSONModel", "sap/m/ResponsivePopover", "sap/m/MessagePopover", "sap/m/ActionSheet", "sap/m/Button", "sap/m/Link", "sap/m/Bar", "sap/ui/layout/VerticalLayout", "sap/m/NotificationListItem", "sap/m/MessagePopoverItem", "sap/ui/core/CustomData", "sap/m/MessageToast"], System.String), function (Device) {
    var newObj = UI5.Glue.CreateRawClassObject(manu.toolpageapp.fv.controller.App);
    newObj._bExpanded = true;
    newObj.Device = Device;
    return sap.ui.core.mvc.Controller.extend("manu.toolpageapp.fv.controller.App", newObj);
});
