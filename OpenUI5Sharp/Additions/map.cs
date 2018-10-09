using System;
using System.Collections;
using System.Collections.Generic;
using Bridge;

namespace UI5
{
    /// <summary>
    /// This class represents a Map with string keys and TValue values, but using just javascript properties
    /// </summary>
    /// <typeparam name="TValue">The type of </typeparam>
    [External]
    [Constructor("{}")]
    public class Map<TValue> : IEnumerable
    {
        [Template("{this}[{key}] = {value}")]
        public extern void Add(string key, TValue value);

        extern IEnumerator IEnumerable.GetEnumerator();

        [Template("{this}['{TType}']")]
        public extern TType Get<TType>();

        [Template("{this}['{TType}'] = {value}")]
        public extern TType Set<TType>(object value);
    }

    /// <summary>
    /// This class represents a Map from string to object, but using just javascript properties
    /// </summary>
    [External]
    [Constructor("{}")]
    public class Map : Map<object>
    {
    }
}
