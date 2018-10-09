using System;
using Bridge;
using static Retyped.sinon.Sinon;

namespace UI5.Tests
{
    /// <summary>
    /// Base class for Unit Tests with Qunit and SinonJS
    /// </summary>
    /// <remarks>You should add "sap/ui/thirdparty/sinon" and "sap/ui/thirdparty/sinon-qunit" as a dependency when you inherit from this class</remarks>
    [FileName("openui5sharp-test.js")]
    public partial class BaseUnitTest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BaseUnitTest()
        {
            Configure();
        }

        /// <summary>
        /// As sinon adds a lot of stuff to a unit test, we configure it to add those stuff to this instance
        /// </summary>
        public virtual void Configure()
        {
            Retyped.dom.window["sinon"]["config"]["injectIntoThis"] = false;
            Retyped.dom.window["sinon"]["config"]["injectInto"] = this;
        }

        // these methods get injected by sinon

        [External]
        public extern virtual SinonSpy spy();
        [External]
        public extern virtual SinonSpy spy(object func);
        [External]
        public extern virtual SinonSpy spy(object obj, string method);

        [External]
        public extern virtual SinonStub stub();
        [External]
        public extern virtual SinonStub stub(object obj);
        [External]
        public extern virtual SinonStub stub(object obj, string method);
        [External]
        public extern virtual SinonStub stub(object obj, string method, object func);

        [External]
        public extern virtual SinonMock mock();
        [External]
        public extern virtual SinonMock mock(object obj);

        [External]
        public extern virtual SinonFakeTimers clock();
        [External]
        public extern virtual SinonFakeTimers clock(params string[] timers);
        [External]
        public extern virtual SinonFakeTimers clock(double now, params string[] timers);

        [External]
        public extern virtual SinonSandbox sandbox();
    }
}
