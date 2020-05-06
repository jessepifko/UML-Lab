using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_12_Class_UML
{
    class Person
    {
        public string Name { get; set; }   
        public string Address { get; set; }

        public Person() { }
        public Person (string _name, string _address)
        {
           Name = _name;
           Address = _address;
        }

        public override string ToString()
        {
            return ($"Person: {Name} {Address}");
        }
    }
    
}
