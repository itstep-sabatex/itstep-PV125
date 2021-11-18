using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeDemo
{
    internal class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }
    internal class PhoneNumber
    {
        public string Type { get; set; }
        public string Number { get; set; }
    }

    internal class Child
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    internal class ClassA
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }

        public bool IsAlive { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public List<PhoneNumber> PhoneNumbers { get; set; }
        public List<Child> Children { get; set;}
  
    }
}
