using Bridge;
using System;
using System.Linq;
using UI5;
using UI5.Tests;
using System.Collections.Generic;
using static Retyped.qunit;
using static Retyped.sinon.Sinon;

namespace ClientScripts.Test.Unit
{
    [FileName("test/unit/model/formatter.js")]
    public class TestFormatter : BaseUnitTest
    {
        [Init(InitPosition.Bottom)]
        public static void DefineScript()
        {
            sap.ui.define(new string[] {
                    "manu/toolpageapp/fv/model/formatter",
                    "sap/ui/thirdparty/sinon",
                    "sap/ui/thirdparty/sinon-qunit"
                },
                new Action<Formatter>(
                    (formatter) => {
                        var testObj = new TestFormatter();
                        testObj.formatter = formatter;

                        QUnit.module("homeImages", new Hooks() {
                            beforeEach = (Assert assert) => {
                                testObj.formatter = formatter;
                            }
                        });

                        QUnit.test("Should display the reduced image on small screen sizes", (Assert assert) => {
                            testObj.imageSourceTestCase(assert, true, "/images/homeImage_small.jpg");
                        });

                        QUnit.test("Should display the original image on large screen sizes", (Assert assert) => {
                            testObj.imageSourceTestCase(assert, false, "/images/homeImage.jpg");
                        });
                    }
                )
            );
        }

        public Formatter formatter;
        public sap.ui.model.Model oDeviceModel;

        public void imageSourceTestCase(Assert assert, bool bValue, string fExpectedSourceImage)
        {
            // Act
            var sImageSrc = formatter.srcImageValue(bValue);

            // Assert
            assert.strictEqual(sImageSrc, fExpectedSourceImage, "The right image version is displayed");
        }
    }
}