using Bridge;
using System;

namespace ODatav4ClientScripts
{
    [External]
    [ObjectLiteral]
    public class People
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }

}