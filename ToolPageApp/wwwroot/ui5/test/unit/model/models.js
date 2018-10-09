Bridge.assembly("ClientScripts", function ($asm, globals) {
    "use strict";

    Bridge.define("ClientScripts.Test.Unit.TestModels", {
        inherits: [UI5.Tests.BaseUnitTest],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"},{"a":2,"n":"DefineScript","is":true,"t":8,"sn":"DefineScript","rt":System.Void},{"a":2,"n":"isPhoneTestCase","t":8,"pi":[{"n":"assert","pt":Bridge.virtualc("Assert"),"ps":0},{"n":"bIsPhone","pt":System.Boolean,"ps":1}],"sn":"isPhoneTestCase","rt":System.Void,"p":[Bridge.virtualc("Assert"),System.Boolean]},{"a":2,"n":"isTouchTestCase","t":8,"pi":[{"n":"assert","pt":Bridge.virtualc("Assert"),"ps":0},{"n":"bIsTouch","pt":System.Boolean,"ps":1}],"sn":"isTouchTestCase","rt":System.Void,"p":[Bridge.virtualc("Assert"),System.Boolean]},{"a":2,"n":"models","t":4,"rt":manu.toolpageapp.fv.model.Models,"sn":"models"},{"a":2,"n":"oDeviceModel","t":4,"rt":sap.ui.model.Model,"sn":"oDeviceModel"}]}; },
        fields: {
            models: null,
            oDeviceModel: null
        },
        methods: {
            isPhoneTestCase: function (assert, bIsPhone) {
                var $t, $t1, $t2, $t3;
                // Arrange
                this.stub(sap.ui.Device, "system", { phone: bIsPhone });

                // System under test
                this.oDeviceModel = new manu.toolpageapp.fv.model.Models().createDeviceModel();

                // Assert
                assert.strictEqual(sapuimodelModelExtensions.getPropertyFor(sap.ui.Device, System.Boolean, this.oDeviceModel, ($t = { ntype: 38, t: sap.ui.Device, n: "p" }, ($t3 = ($t2 = {"td":sap.ui.Device.system,"a":2,"n":"phone","t":4,"rt":System.Boolean,"sn":"phone","box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}}, { ntype: 23, t: $t2.rt, expression: ($t1 = {"td":sap.ui.Device,"a":2,"n":"system","t":4,"rt":sap.ui.Device.system,"sn":"system"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), member: $t2 }), { ntype: 18, t: Function, rt: $t3.t, body: $t3, p: Bridge.toList([$t]) }))), bIsPhone, "IsPhone property is correct");
            },
            isTouchTestCase: function (assert, bIsTouch) {
                var $t, $t1, $t2, $t3;
                // Arrange
                this.stub(sap.ui.Device, "support", { touch: bIsTouch });

                // System under test
                this.oDeviceModel = new manu.toolpageapp.fv.model.Models().createDeviceModel();

                // Assert
                assert.strictEqual(sapuimodelModelExtensions.getPropertyFor(sap.ui.Device, System.Boolean, this.oDeviceModel, ($t = { ntype: 38, t: sap.ui.Device, n: "p" }, ($t3 = ($t2 = {"td":sap.ui.Device.support,"a":2,"n":"touch","t":4,"rt":System.Boolean,"sn":"touch","box":function ($v) { return Bridge.box($v, System.Boolean, System.Boolean.toString);}}, { ntype: 23, t: $t2.rt, expression: ($t1 = {"td":sap.ui.Device,"a":2,"n":"support","t":4,"rt":sap.ui.Device.support,"sn":"support"}, { ntype: 23, t: $t1.rt, expression: $t, member: $t1 }), member: $t2 }), { ntype: 18, t: Function, rt: $t3.t, body: $t3, p: Bridge.toList([$t]) }))), bIsTouch, "IsTouch property is correct");
            }
        }
    });
});

sap.ui.define(System.Array.init(["manu/toolpageapp/fv/model/models", "sap/ui/thirdparty/sinon", "sap/ui/thirdparty/sinon-qunit"], System.String), function (models) {
    var testObj = new ClientScripts.Test.Unit.TestModels();
    testObj.models = models;

    QUnit.module("createDeviceModel", { afterEach: function (assert) {
        testObj.oDeviceModel.destroy();
    } });

    QUnit.test("Should initialize a device model for desktop", function (assert) {
        testObj.isPhoneTestCase(assert, false);
    });

    QUnit.test("Should initialize a device model for phone", function (assert) {
        testObj.isPhoneTestCase(assert, true);
    });

    QUnit.test("Should initialize a device model for non touch devices", function (assert) {
        testObj.isTouchTestCase(assert, false);
    });

    QUnit.test("Should initialize a device model for touch devices", function (assert) {
        testObj.isTouchTestCase(assert, true);
    });

    QUnit.test("The binding mode of the device model should be one way", function (assert) {
        // System under test
        testObj.oDeviceModel = new manu.toolpageapp.fv.model.Models().createDeviceModel();

        // Assert
        assert.strictEqual(testObj.oDeviceModel.getDefaultBindingMode(), sap.ui.model.BindingMode.OneWay, "Binding mode is correct");
    });
});
