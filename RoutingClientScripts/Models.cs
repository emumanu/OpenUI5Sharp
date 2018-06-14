using System;
using Bridge;

namespace RoutingClientScripts
{
    [External]
    [ObjectLiteral]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public int ResumeID { get; set; }
    }

    [External]
    [ObjectLiteral]
    public class Resume
    {
        public int ResumeID { get; set; }
        public string Information { get; set; }
        public string Projects { get; set; }
        public string Hobbies { get; set; }
        public string Notes { get; set; }
    }
}
