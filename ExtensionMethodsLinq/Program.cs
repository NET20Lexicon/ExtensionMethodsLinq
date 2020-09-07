using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hej";
            var res = str.Add("Banan");

            Console.WriteLine(res);

            var emp = new Employee("Kalle", 10000);
            var nameToUper = emp.NameToUpper();

            Console.WriteLine(nameToUper);

            var employees = new List<Employee>
            {
                new Employee("Nisse", 265656),
                new Employee("Pelle" ,265),
                new Employee("Olle" ,16466),
                new Employee("Sara" ,854),
                new Employee("Ida" ,536),
                new Employee("Fia", 54556),
            };

            int[] num = Enumerable.Range(1, 10).ToArray();
            List<int> num2 = Enumerable.Range(1, 10).ToList();
            IEnumerable<int> num3 = Enumerable.Range(1, 10);

            num.PrintAll();
            num2.PrintAll();
            num3.PrintAll();

            employees.PrintAll();

        }
    }
}
