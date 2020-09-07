using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExtensionMethodsLinq
{
    public static class Extensions
    {
        public static string Add(this string str, string input)
        {
            return $"Org string: {str}, input {input}";
        }

        public static string NameToUpper(this Employee employee)
        {
            return employee.Name.ToUpper();
        }

        //public static void PrintAll(this List<Employee> collection)
        //{
        //    collection.ForEach((e) =>
        //    {
        //        //blaha 
        //        Console.WriteLine(e);

        //    });

        //}

        public static void PrintAll<T>(this IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
