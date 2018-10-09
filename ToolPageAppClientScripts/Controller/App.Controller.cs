using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Extensions;
using System.Collections.Generic;

namespace ClientScripts
{
    [FileName("controller/App.controller.js")]
    [Name("manu.toolpageapp.fv.controller.App")]
    public class AppController : BaseController
    {
        public bool _bExpanded;
        sap.ui.Device Device;
        sap.ui.core.mvc.View oView;

        [Init(InitPosition.Top)]
        public static void RequireScript()
        {
            jQuery.sap.require("manu/toolpageapp/fv/controller/BaseController");
        }

        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "sap/ui/Device",
                    "jquery.sap.global",
                    "sap/ui/core/Fragment",
                    "sap/ui/core/mvc/Controller",
                    "sap/ui/model/json/JSONModel",
                    "sap/m/ResponsivePopover",
                    "sap/m/MessagePopover",
                    "sap/m/ActionSheet",
                    "sap/m/Button",
                    "sap/m/Link",
                    "sap/m/Bar",
                    "sap/ui/layout/VerticalLayout",
                    "sap/m/NotificationListItem",
                    "sap/m/MessagePopoverItem",
                    "sap/ui/core/CustomData",
                    "sap/m/MessageToast"
                },
                new Func<sap.ui.Device, object>(
                    (Device) => {
                        AppController newObj = Glue.CreateRawClassObject<AppController>();
                        newObj._bExpanded = true;
                        newObj.Device = Device;
                        return BaseController.extend(nameof(AppController), newObj);
                    }
                )
            );
        }

        AppController(Union<string, object[]> sName) : base(sName)
        {
        }

        public override void onInit()
        {
            oView = this.getView();
            oView.addStyleClass(this.getOwnerComponent<Component>().getContentDensityClass());

            // if the app starts on desktop devices with small or medium screen size, collapses the side navigation
            if (Device.resize.width <= 1024) {
                this.onSideNavButtonPress();
            }
            Device.media.attachHandler((sap.ui.Device.Media.MediaRangeChangeInfo oDevice) => {
                if ((oDevice.name == "Tablet" && this._bExpanded) || (oDevice.name == "Desktop")) {
                    this.onSideNavButtonPress();
                    // set the _bExpanded to false on tablet devices
                    // extending and collapsing of side navigation should be done when resizing from
                    // desktop to tablet screen sizes)
                    this._bExpanded = (oDevice.name == "Desktop");
                }
            });
        }

        /// <summary>
        /// Convenience method for accessing the router
        /// </summary>
        /// <param name="oEvent">The item select event</param>
        /// <param name="oData">not used</param>
        public void onItemSelect(sap.ui.@base.Event<sap.m.ItemSelectInfo> oEvent, object oData)
        {
            sap.tnt.NavigationListItem oItem = oEvent.getParameterFor(p => p.item).As<sap.tnt.NavigationListItem>();
            string sKey = oItem.getKey();
            // if you click on home, settings or statistics button, call the navTo function
            if ((sKey == "home" || sKey == "masterSettings" || sKey == "statistics")) {
                // if the device is phone, collaps the navigation side of the app to give more space
                if (Device.system.phone) {
                    this.onSideNavButtonPress();
                }
                this.getRouter().navTo(sKey);
            } else {
                sap.m.MessageToast.show(sKey);
            }
        }

        public void onUserNamePress(sap.ui.@base.Event oEvent, object oData)
        {
            var oBundle = (jQuery.sap.util.ResourceBundle)this.getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle();

            // close message popover
            sap.m.MessagePopover oMessagePopover = this.byId<sap.m.MessagePopover>("errorMessagePopover");
            if ((oMessagePopover != null) && oMessagePopover.isOpen()) {
                oMessagePopover.destroy();
            }

            void fnHandleUserMenuItemPress(sap.ui.@base.Event oEvt, object data) {
                sap.m.MessageToast.show(oEvt.getSource<sap.m.Button>().getText() + " was pressed");
            }

            sap.m.ActionSheet oActionSheet = new sap.m.ActionSheet(oView.createId("userMessageActionSheet"), new sap.m.ActionSheet.Settings() {
                title = oBundle.getText("userHeaderTitle"),
                showCancelButton = false,
                buttons = new sap.m.Button[] {
                    new sap.m.Button(new sap.m.Button.Settings() {
                        text = "User Settings",
                        type = sap.m.ButtonType.Transparent,
                        press = fnHandleUserMenuItemPress
                    }),
                    new sap.m.Button(new sap.m.Button.Settings() {
                        text = "Online Guide",
                        type = sap.m.ButtonType.Transparent,
                        press = fnHandleUserMenuItemPress
                    }),
                    new sap.m.Button(new sap.m.Button.Settings() {
                        text = "Feedback",
                        type = sap.m.ButtonType.Transparent,
                        press = fnHandleUserMenuItemPress
                    }),
                    new sap.m.Button(new sap.m.Button.Settings() {
                        text = "Help",
                        type = sap.m.ButtonType.Transparent,
                        press = fnHandleUserMenuItemPress
                    }),
                    new sap.m.Button(new sap.m.Button.Settings() {
                        text = "Logout",
                        type = sap.m.ButtonType.Transparent,
                        press = fnHandleUserMenuItemPress
                    })
                },
                afterClose = (sap.ui.@base.Event ev, object d) => {
                    ev.getSource().destroy();
                }
            });

            // forward compact/cozy style into dialog
            jQuery.sap.syncStyleClass(oView.getController<AppController>().getOwnerComponent<Component>().getContentDensityClass(), oView, oActionSheet);
            oActionSheet.openBy(oEvent.getSource());
        }

        public void onSideNavButtonPress(sap.ui.@base.Event oEvent = null, object oData = null)
        {
            sap.tnt.ToolPage oToolPage = this.byId<sap.tnt.ToolPage>("app");
            bool bSideExpanded = oToolPage.getSideExpanded();
            this._setToggleButtonTooltip(bSideExpanded);
            oToolPage.setSideExpanded(!oToolPage.getSideExpanded());
        }

        public void _setToggleButtonTooltip(bool bSideExpanded)
        {
            sap.m.Button oToggleButton = this.byId<sap.m.Button>("sideNavigationToggleButton");
            if (bSideExpanded) {
                oToggleButton.setTooltip("Large Size Navigation");
            } else {
                oToggleButton.setTooltip("Small Size Navigation");
            }
        }

        // Errors Pressed
        public void onMessagePopoverPress(sap.ui.@base.Event oEvent, object oData)
        {
            if (this.byId<sap.m.MessagePopover>("errorMessagePopover") == null) {
                sap.m.MessagePopover oMessagePopover = new sap.m.MessagePopover(oView.createId("errorMessagePopover"), new sap.m.MessagePopover.Settings() {
                    placement = sap.m.VerticalPlacementType.Bottom,
                    items = new sap.ui.@base.ManagedObject.BindAggregationInfo() {
                        path = "alerts>/alerts/errors",
                        factory = this._createError
                    },
                    afterClose = (sap.ui.@base.Event<sap.m.AfterOpenCloseBeforeInfo> ev, object data) => {
                        ev.getSource().destroy();
                    }
                });

                this.byId("app").addDependent(oMessagePopover);

                // forward compact/cozy style into dialog
                jQuery.sap.syncStyleClass(oView.getController<AppController>().getOwnerComponent<Component>().getContentDensityClass(), oView, oMessagePopover);
                oMessagePopover.openBy(oEvent.getSource<sap.ui.core.Control>());
            }
        }

        /// <summary>
        /// Event handler for the notification button
        /// </summary>
        /// <param name="oEvent">the button press event</param>
        /// <param name="oData">not used</param>
        public void onNotificationPress(sap.ui.@base.Event oEvent, object oData)
        {
            var oBundle = (jQuery.sap.util.ResourceBundle)this.getModel<sap.ui.model.resource.ResourceModel>("i18n").getResourceBundle();
            // close message popover
            sap.m.MessagePopover oMessagePopover = this.byId<sap.m.MessagePopover>("errorMessagePopover");
            if ((oMessagePopover != null) && oMessagePopover.isOpen()) {
                oMessagePopover.destroy();
            }
            sap.m.Button oButton = new sap.m.Button(new sap.m.Button.Settings() {
                text = oBundle.getText("notificationButtonText"),
                press = ((sap.ui.@base.Event oEvt, object data) => {
                    sap.m.MessageToast.show("Show all Notifications was pressed");
                })
            });
            sap.m.ResponsivePopover oNotificationPopover = new sap.m.ResponsivePopover(oView.createId("notificationMessagePopover"), new sap.m.ResponsivePopover.Settings() {
                title = oBundle.getText("notificationTitle"),
                contentWidth = "300px",
                endButton = oButton,
                placement = sap.m.PlacementType.Bottom,
                content = new sap.ui.@base.ManagedObject.BindAggregationInfo() {
                    path = "alerts>/alerts/notifications",
                    factory = this._createNotification
                },
                afterClose = (sap.ui.@base.Event<sap.m.CloseInfo> ev, object data) => {
                    ev.getSource().destroy();
                }
            });

            this.byId("app").addDependent(oNotificationPopover);

            // forward compact/cozy style into dialog
            jQuery.sap.syncStyleClass(oView.getController<AppController>().getOwnerComponent<Component>().getContentDensityClass(), oView, oNotificationPopover);
            oNotificationPopover.openBy(oEvent.getSource());
        }

        /// <summary>
        /// Factory function for the notification items
        /// </summary>
        /// <param name="sId">sId The id for the item</param>
        /// <param name="oBindingContext">The binding context for the item</param>
        /// <returns>The new notification list item</returns>
        public sap.ui.core.Element _createNotification(string sId, sap.ui.model.Context oBindingContext)
        {
            Notification oBindingObject = oBindingContext.getObject<Notification>();
            sap.m.NotificationListItem oNotificationItem = new sap.m.NotificationListItem(new sap.m.NotificationListItem.Settings() {
                title = oBindingObject.title,
                description = oBindingObject.description,
                priority = oBindingObject.priority,
                close = (sap.ui.@base.Event oEvent, object oData) => {
                    var source = oEvent.getSource<sap.m.NotificationListItem>();
                    string sBindingPath = source.getCustomData()[0].getValue<string>();
                    string sIndex = sBindingPath.Split('/').Last();
                    List<Notification> aItems = source.getModelFor<AlertsModel>("alerts").getPropertyFor(p => p.alerts.notifications).ToList();
                    aItems.RemoveRange(Script.ParseInt(sIndex), 1);
                    source.getModelFor<AlertsModel>("alerts").setPropertyFor(p => p.alerts.notifications, aItems.ToArray());
                    source.getModel<sap.ui.model.json.JSONModel>("alerts").updateBindings(true);
                    sap.m.MessageToast.show("Notification has been deleted.");
                },
                datetime = oBindingObject.date,
                authorPicture = oBindingObject.icon,
                press = (sap.ui.@base.Event oEvent, object oData) => {
                },
                customData = new sap.ui.core.CustomData[] {
                    new sap.ui.core.CustomData(new sap.ui.core.CustomData.Settings() {
                        key = "path",
                        value = oBindingContext.getPath()
                    })
                }
            });

            return oNotificationItem;
		}

        public sap.ui.core.Element _createError(string sId, sap.ui.model.Context oBindingContext)
        {
            Error oBindingObject = oBindingContext.getObject<Error>();
            sap.m.Link oLink = new sap.m.Link(new sap.m.Link.Settings() {
                text = "More Details",
                press = (sap.ui.@base.Event oEvent, object oData) => {
                    sap.m.MessageToast.show("More Details was pressed");
                }
            });
                    
			sap.m.MessagePopoverItem oMessageItem = new sap.m.MessagePopoverItem(new sap.m.MessagePopoverItem.Settings() {
				title = oBindingObject.title,
                subtitle = oBindingObject.subTitle,
                description = oBindingObject.description,
                counter = oBindingObject.counter,
                link = oLink
			});

        	return oMessageItem;
		}
    }
}