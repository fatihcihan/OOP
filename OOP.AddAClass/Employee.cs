using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AddAClass
{
    internal class Employee
    {
        private string _firstName;
        private string _lastName;
        private List<Employee> _list;
        public string FirstName     // encapsulation
        {
            set { _firstName = value; }
            get { return _firstName; }
        }
        public string LastName
        {
            // expression-bodied property accessors
            get => _lastName;
            set => _lastName = value;
        }
        public int Age { get; set; }     // auto-implemented property  ->  custom bir control yapilmayacaksa...

        public Employee()   // default olarak zaten var, nesneden instance alinca calisan ilk metot.
        {
            _list = new List<Employee>();
            // Console.WriteLine("Constructor method worked");
        }

        // Overloading
        public Employee(string firstName, string lastName, int age) // this -> Employee classini temsil eder.
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            _list = new List<Employee>();
        }

        public override string ToString()       // Override (object (base) classtan gelen tostring metodunu eziyoruz)
        {
            return $"{FirstName,-20} {LastName,-15} {Age,5}";
        }

        public void Add(Employee employee)
        {
            _list.Add(employee);
        }



    }
}
