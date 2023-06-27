using System;
using System.Collections.Generic;
using System.Text;

namespace ExpressionTrees
{
    public class Person
    {
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{FullName} with national code:{NationalCode} has {Age} old Year";
        }
    }
}
