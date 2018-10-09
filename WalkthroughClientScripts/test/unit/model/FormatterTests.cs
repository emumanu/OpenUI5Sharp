using Bridge;
using System;
using static Retyped.qunit;
using static Retyped.sinon.Sinon;
using UI5;
using UI5.Tests;

namespace WalkthroughClientScripts.Tests
{
    [FileName("test/unit/model/formatter.js")]
    public class FormatterTests : BaseUnitTest
    {
        [Init(InitPosition.Bottom)]
        public static void Script()
        {
            sap.ui.require(new string[] {
                    "sap/ui/demo/walkthrough/model/formatter",
                    "sap/ui/model/resource/ResourceModel",
                    "sap/ui/thirdparty/sinon",
                    "sap/ui/thirdparty/sinon-qunit"
                },
                new Action<Formatter>(
                    (formatter) => {
                        sap.ui.model.resource.ResourceModel oResourceModel = null;

                        QUnit.module("Test Module", new Hooks() {
                            beforeEach = (Assert assert) => {
                                oResourceModel = new sap.ui.model.resource.ResourceModel(new sap.ui.model.resource.ResourceModel.ResourceModelInfo() {
                                    bundleUrl = jQuery.sap.getModulePath("sap.ui.demo.walkthrough", "/i18n/i18n.properties")
                                });
                            },
                            afterEach = (Assert assert) => {
                                oResourceModel.destroy();
                            }
                        });

                        QUnit.test("Should return the translated texts",
                            (Assert assert) => {
                                // Arrange
                                var oModel = This.Instance.As<FormatterTests>().stub();
                                oModel.withArgs("i18n").As<SinonStub>().returns(oResourceModel);
                                var oViewStub = new {
                                    getModel = oModel
                                };
                                var oControllerStub = new {
                                    getView = This.Instance.As<FormatterTests>().stub().returns(oViewStub)
                                };

                                // System under test
                                var fnIsolatedFormatter = Globals.BindMethod<Func<string, string>>(formatter, nameof(formatter.statusText), oControllerStub);

                                assert.strictEqual(fnIsolatedFormatter("A"), "New", "The long text for status A is correct");
                                assert.strictEqual(fnIsolatedFormatter("B"), "In Progress", "The long text for status B is correct");
                                assert.strictEqual(fnIsolatedFormatter("C"), "Done", "The long text for status C is correct");
                                assert.strictEqual(fnIsolatedFormatter("Foo"), "Foo", "The long text for status Foo is correct");
                            }
                        );
                    }
                )
            );
        }
    }
}


