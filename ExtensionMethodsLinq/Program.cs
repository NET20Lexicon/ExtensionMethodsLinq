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
                new Employee("Sopia", 54556),
            };

            var result = employees.Where((e) => e.Salary > 20000);

            foreach (var employee in result)
            {
                Console.WriteLine(employee);
            }

            var sorted = employees.OrderBy(e => e.Name);

            Console.WriteLine("--------------------------");

            foreach (var employee in sorted)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("--------------------------");

            var startsWithA = employees
                .Where(e => e.Name.StartsWith("S"))
                .Where(e => e.Name.EndsWith("a"))
                .Select(e => e.Salary)
                .Sum();

            var namesLength = employees
                .Where(e => e.Salary > 11000)
                .Select(e => new EmpDto
                {
                    Name = e.Name.ToUpper(),
                    NamesLength = e.Name.Length
                })
                .ToArray();





            int[] num = Enumerable.Range(1, 10).ToArray();
            List<int> num2 = Enumerable.Range(1, 10).ToList();
            IEnumerable<int> num3 = Enumerable.Range(1, 10);

            var ints = new[] { 1, 35, 234, 45, 2, 6457, 56, 34, 3, 353 };

            num.PrintAll<int>();
            num2.PrintAll();
            num3.PrintAll();

            employees.PrintAll();

        }
    }
}
