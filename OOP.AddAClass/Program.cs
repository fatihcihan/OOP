using System;
using System.Collections.Generic;

namespace OOP.AddAClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Employee>()
            {
                new Employee {FirstName="Fatih", LastName="Cihan", Age=30},
                new Employee {FirstName="Mehmet", LastName="Özer", Age=20},
                new Employee {FirstName="Merve", LastName="Aslan", Age=25},
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            //Employee employee = new Employee()
            //{
            //    FirstName = "Fatih",
            //    LastName = "Cihan",
            //    Age = 30,
            //};
            //Employee employee2 = new Employee("Mehmet", "Özer", 30);
            //Employee employee3 = new Employee("Merve", "Aslan", 20);

            //list.Add(employee);
            //list.Add(employee2);
            //list.Add(employee3);
        }
    }
}
