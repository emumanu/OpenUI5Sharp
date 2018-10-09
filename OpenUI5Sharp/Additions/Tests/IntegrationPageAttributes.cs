using System;
using Bridge;

namespace UI5.Tests
{
    /// <summary>
    /// Attribute to mark actions
    /// </summary>
    [FileName("openui5sharp-test.js")]
    [AttributeUsage(AttributeTargets.Method)]
    public partial class OpaActionAttribute : Attribute
    {
    }

    /// <summary>
    /// Attribute to mark assertions
    /// </summary>
    [FileName("openui5sharp-test.js")]
    [AttributeUsage(AttributeTargets.Method)]
    public partial class OpaAssertionAttribute : Attribute
    {
    }
}