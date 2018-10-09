using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Tests;
using UI5.Extensions;
using System.Collections.Generic;
using static Retyped.qunit;
using static Retyped.sinon.Sinon;

namespace ClientScripts.Test.Unit
{
    [FileName("test/unit/model/models.js")]
    public class TestModels : BaseUnitTest
    {
        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "manu/toolpageapp/fv/model/models",
                    "sap/ui/thirdparty/sinon",
                    "sap/ui/thirdparty/sinon-qunit"
                },
                new Action<Models>(
                    (models) => {
                        var testObj = new TestModels();
                        testObj.models = models;

                        QUnit.module("createDeviceModel", new Hooks() {
                            afterEach = (Assert assert) => {
                                testObj.oDeviceModel.destroy();
                            }
                        });

                        QUnit.test("Should initialize a device model for desktop", (Assert assert) => {
                            testObj.isPhoneTestCase(assert, false);
                        });

                        QUnit.test("Should initialize a device model for phone", (Assert assert) => {
                            testObj.isPhoneTestCase(assert, true);
                        });

                        QUnit.test("Should initialize a device model for non touch devices", (Assert assert) => {
                            testObj.isTouchTestCase(assert, false);
                        });

                        QUnit.test("Should initialize a device model for touch devices", (Assert assert) => {
                            testObj.isTouchTestCase(assert, true);
                        });

                        QUnit.test("The binding mode of the device model should be one way", (Assert assert) => {
                            // System under test
                            testObj.oDeviceModel = new Models().createDeviceModel();

                            // Assert
                            assert.strictEqual(testObj.oDeviceModel.getDefaultBindingMode(), sap.ui.model.BindingMode.OneWay, "Binding mode is correct");
                        });
                    }
                )
            );
        }

        public Models models;
        public sap.ui.model.Model<sap.ui.Device> oDeviceModel;

        public void isPhoneTestCase(Assert assert, bool bIsPhone)
        {
            // Arrange
            this.stub(sap.ui.Device.Singleton, "system", new { phone = bIsPhone });

            // System under test
            this.oDeviceModel = new Models().createDeviceModel();

            // Assert
            assert.strictEqual(this.oDeviceModel.getPropertyFor(p => p.system.phone), bIsPhone, "IsPhone property is correct");
        }

        public void isTouchTestCase(Assert assert, bool bIsTouch)
        {
            // Arrange
            this.stub(sap.ui.Device.Singleton, "support", new { touch = bIsTouch });

            // System under test
            this.oDeviceModel = new Models().createDeviceModel();

            // Assert
            assert.strictEqual(this.oDeviceModel.getPropertyFor(p => p.support.touch), bIsTouch, "IsTouch property is correct");
        }
    }
}