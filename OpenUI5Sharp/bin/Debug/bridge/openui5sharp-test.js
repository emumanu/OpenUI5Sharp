sap.ui.require(System.Array.init(["sap/ui/test/Opa5"], System.String));

Bridge.assembly("OpenUI5Sharp", function ($asm, globals) {
    "use strict";

    var sinon;

    /** @namespace UI5.Tests */

    /**
     * Base class for Integration steps for OPA Tests
     *
     * @public
     * @class UI5.Tests.BaseIntegrationPage
     * @augments sap.ui.test.Opa5
     */
    Bridge.define("UI5.Tests.BaseIntegrationPage", {
        inherits: [sap.ui.test.Opa5],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"p":[sap.ui.test.Opa5],"pi":[{"n":"Opa5","pt":sap.ui.test.Opa5,"ps":0}],"sn":"ctor"},{"v":true,"a":2,"n":"GetInstanceWithMethods","t":8,"pi":[{"n":"attributeType","pt":Function,"ps":0}],"sn":"GetInstanceWithMethods","rt":System.Object,"p":[Function]},{"v":true,"a":2,"n":"GetPageObject","t":8,"sn":"GetPageObject","rt":System.Object},{"a":2,"n":"IncludeDependencies","is":true,"t":8,"sn":"IncludeDependencies","rt":System.Void},{"a":2,"n":"Opa5","is":true,"t":4,"rt":sap.ui.test.Opa5,"sn":"Opa5"}]}; },
        statics: {
            fields: {
                Opa5: null
            }
        },
        ctors: {
            ctor: function (Opa5) {
                this.$initialize();
                sap.ui.test.Opa5.call(this);
                UI5.Tests.BaseIntegrationPage.Opa5 = Opa5;
            }
        },
        methods: {
            /**
             * Method that creates an object instance with some methods that have an associated attribute
             *
             * @instance
             * @public
             * @this UI5.Tests.BaseIntegrationPage
             * @memberof UI5.Tests.BaseIntegrationPage
             * @param   {Function}         attributeType    attribute used to filter the methods to return
             * @return  {System.Object}                     A new instance with the requested methods
             */
            GetInstanceWithMethods: function (attributeType) {
                var $t, $t1;
                var type = Bridge.getType(this);
                var obj = { };

                $t = Bridge.getEnumerator(Bridge.Reflection.getMembers(type, 4, 28));
                try {
                    while ($t.moveNext()) {
                        var field = $t.Current;
                        obj[field.sn] = this[field.sn];
                    }
                } finally {
                    if (Bridge.is($t, System.IDisposable)) {
                        $t.System$IDisposable$Dispose();
                    }
                }
                ;

                $t1 = Bridge.getEnumerator(System.Linq.Enumerable.from(Bridge.Reflection.getMembers(type, 8, 28)).where(function (m) {
                        return System.Attribute.getCustomAttributes(m, attributeType).length > 0;
                    }));
                try {
                    while ($t1.moveNext()) {
                        var method = $t1.Current;
                        obj[method.sn] = this[method.sn];
                    }
                } finally {
                    if (Bridge.is($t1, System.IDisposable)) {
                        $t1.System$IDisposable$Dispose();
                    }
                }
                ;

                return obj;
            },
            /**
             * Creates a page object based on this instance of the integration page
             *
             * @instance
             * @public
             * @this UI5.Tests.BaseIntegrationPage
             * @memberof UI5.Tests.BaseIntegrationPage
             * @return  {sap.ui.test.Opa5.CreatePageObjectsInfo}        An object with the actions and assertions set to new object instances that have only the methods with OpaAaction and OpaAssertion respectively
             */
            GetPageObject: function () {
                return { actions: this.GetInstanceWithMethods(UI5.Tests.OpaActionAttribute), assertions: this.GetInstanceWithMethods(UI5.Tests.OpaAssertionAttribute) };
            }
        }
    });

    /**
     * Base class for Unit Tests with Qunit and SinonJS
     *
     * @public
     * @class UI5.Tests.BaseUnitTest
     */
    Bridge.define("UI5.Tests.BaseUnitTest", {
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"n":".ctor","t":1,"sn":"ctor"},{"v":true,"a":2,"n":"Configure","t":8,"sn":"Configure","rt":System.Void},{"v":true,"a":2,"n":"clock","t":8,"sn":"clock","rt":Bridge.virtualc("sinon.SinonFakeTimers")},{"v":true,"a":2,"n":"clock","t":8,"pi":[{"n":"timers","ip":true,"pt":System.Array.type(System.String),"ps":0}],"sn":"clock","rt":Bridge.virtualc("sinon.SinonFakeTimers"),"p":[System.Array.type(System.String)]},{"v":true,"a":2,"n":"clock","t":8,"pi":[{"n":"now","pt":System.Double,"ps":0},{"n":"timers","ip":true,"pt":System.Array.type(System.String),"ps":1}],"sn":"clock","rt":Bridge.virtualc("sinon.SinonFakeTimers"),"p":[System.Double,System.Array.type(System.String)]},{"v":true,"a":2,"n":"mock","t":8,"sn":"mock","rt":Bridge.virtualc("sinon.SinonMock")},{"v":true,"a":2,"n":"mock","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0}],"sn":"mock","rt":Bridge.virtualc("sinon.SinonMock"),"p":[System.Object]},{"v":true,"a":2,"n":"sandbox","t":8,"sn":"sandbox","rt":Bridge.virtualc("sinon.SinonSandbox")},{"v":true,"a":2,"n":"spy","t":8,"sn":"spy","rt":Bridge.virtualc("sinon.SinonSpy")},{"v":true,"a":2,"n":"spy","t":8,"pi":[{"n":"func","pt":System.Object,"ps":0}],"sn":"spy","rt":Bridge.virtualc("sinon.SinonSpy"),"p":[System.Object]},{"v":true,"a":2,"n":"spy","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0},{"n":"method","pt":System.String,"ps":1}],"sn":"spy","rt":Bridge.virtualc("sinon.SinonSpy"),"p":[System.Object,System.String]},{"v":true,"a":2,"n":"stub","t":8,"sn":"stub","rt":Bridge.virtualc("sinon.SinonStub")},{"v":true,"a":2,"n":"stub","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0}],"sn":"stub","rt":Bridge.virtualc("sinon.SinonStub"),"p":[System.Object]},{"v":true,"a":2,"n":"stub","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0},{"n":"method","pt":System.String,"ps":1}],"sn":"stub","rt":Bridge.virtualc("sinon.SinonStub"),"p":[System.Object,System.String]},{"v":true,"a":2,"n":"stub","t":8,"pi":[{"n":"obj","pt":System.Object,"ps":0},{"n":"method","pt":System.String,"ps":1},{"n":"func","pt":System.Object,"ps":2}],"sn":"stub","rt":Bridge.virtualc("sinon.SinonStub"),"p":[System.Object,System.String,System.Object]}]}; },
        ctors: {
            /**
             * Constructor
             *
             * @instance
             * @public
             * @this UI5.Tests.BaseUnitTest
             * @memberof UI5.Tests.BaseUnitTest
             * @return  {void}
             */
            ctor: function () {
                this.$initialize();
                this.Configure();
            }
        },
        methods: {
            /**
             * As sinon adds a lot of stuff to a unit test, we configure it to add those stuff to this instance
             *
             * @instance
             * @public
             * @this UI5.Tests.BaseUnitTest
             * @memberof UI5.Tests.BaseUnitTest
             * @return  {void}
             */
            Configure: function () {
                window.sinon.config.injectIntoThis = false;
                window.sinon.config.injectInto = this;
            }
        }
    });

    /**
     * Attribute to mark actions
     *
     * @public
     * @class UI5.Tests.OpaActionAttribute
     * @augments System.Attribute
     */
    Bridge.define("UI5.Tests.OpaActionAttribute", {
        inherits: [System.Attribute],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"}]}; }
    });

    /**
     * Attribute to mark assertions
     *
     * @public
     * @class UI5.Tests.OpaAssertionAttribute
     * @augments System.Attribute
     */
    Bridge.define("UI5.Tests.OpaAssertionAttribute", {
        inherits: [System.Attribute],
        $metadata : function () { return {"att":1048577,"a":2,"m":[{"a":2,"isSynthetic":true,"n":".ctor","t":1,"sn":"ctor"}]}; }
    });
});
