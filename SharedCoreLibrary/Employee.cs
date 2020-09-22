using System;
using System.Collections.Generic;
using System.Text;

namespace SharedCoreLibrary
{
    public class Employee
    {
        public Employee(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname { get; }
        public string Lastname { get; }
    }
}
