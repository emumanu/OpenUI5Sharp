using System;
using Bridge;

namespace UI5.Tests
{
    /// <summary>
    /// Attribute to mark actions
    /// </summary>
    [FileName("openui5sharp-test.js")]
    [AttributeUsage(AttributeTargets.Method)]
    [Name("UI5.Tests.OpaActionAttribute")]
    public partial class OpaActionAttribute : Attribute
    {
    }

    /// <summary>
    /// Attribute to mark assertions
    /// </summary>
    [FileName("openui5sharp-test.js")]
    [AttributeUsage(AttributeTargets.Method)]
    [Name("UI5.Tests.OpaAssertionAttribute")]
    public partial class OpaAssertionAttribute : Attribute
    {
    }
}