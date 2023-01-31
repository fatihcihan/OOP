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

            employee.AddRange(
                new Employee("Merve", "Aslan", 25),
                new Employee("Murat", "Akay", 20),
                new Employee("Elif", "Han", 33)
                );

            var list = employee.GetEmployees();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
