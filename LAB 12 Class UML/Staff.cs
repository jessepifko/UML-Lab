using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_12_Class_UML
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff() { }
        public Staff(string _name, string _address, string _school, double _pay) : base(_name, _address)
        {
            School = _school;
            Pay = _pay;
        }

        public override string ToString()
        {
            return ($"Staff: {Name} {Address} {School} {Pay}");
        }
    }
}
