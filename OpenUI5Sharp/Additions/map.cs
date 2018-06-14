using System;
using System.Collections;
using System.Collections.Generic;
using Bridge;

namespace OpenUI5Sharp
{
    /// <summary>
    /// This class represents a Map with string keys and TValue values, but using just javascript properties
    /// </summary>
    /// <typeparam name="TValue">The type of </typeparam>
    [External]
    [Constructor("{}")]
    [Namespace(false)]
    public class Map<TValue> : IEnumerable
    {
        [Template("{this}[{key}] = {value}")]
        public extern void Add(string key, TValue value);

        [External]
        extern IEnumerator IEnumerable.GetEnumerator();
    }

    /// <summary>
    /// This class represents a Map from string to object, but using just javascript properties
    /// </summary>
    [External]
    [Constructor("{}")]
    [Namespace(false)]
    public class Map : Map<object>
    {
    }
}
