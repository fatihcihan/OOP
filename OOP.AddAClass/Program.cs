using System;
using System.Collections.Generic;

namespace OOP.AddAClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.Add(new Employee { FirstName = "Fatih", LastName = "Cihan", Age = 30 });

            Console.ReadLine();            
        }
    }
}
