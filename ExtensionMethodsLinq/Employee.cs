using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsLinq
{
    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public string NameToUpper()
        {
            return Name.ToUpper();
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }


    }
}
