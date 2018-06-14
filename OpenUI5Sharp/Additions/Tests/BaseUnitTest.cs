using System;
using Bridge;
using static Retyped.sinon.Sinon;

namespace OpenUI5Sharp
{
    /// <summary>
    /// Base class for Unit Tests with Qunit and SinonJS
    /// </summary>
    [FileName("openui5sharp-test.js")]
    public partial class BaseUnitTest
    {
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
