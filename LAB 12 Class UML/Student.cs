using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_12_Class_UML
{
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student() { }
        public Student(string _name, string _address, string _program, int _year, double _fee) : base(_name, _address)
        {
            Program = _program;
            Year = _year;
            Fee = _fee;
        }

        public override string ToString()
        {

            return ($"Student: {Name}{Address}{Program}{Year} {Fee}");
        }
    }
}