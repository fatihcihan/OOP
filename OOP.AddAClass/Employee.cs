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

        public string FirstName     // encapsulation
        {
            set { _firstName = value; }
            get { return _firstName; }
        }

    }
}
