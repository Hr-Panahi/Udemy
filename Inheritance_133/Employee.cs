using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_133
{
    class Employee
    {
        //properties
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        //Default/implicit constructor
        public Employee()
        {
            LastName = "Legend";
            FirstName = "Hamid";
            Salary = 1000;
        }

        //explicit constructor
        public Employee(string firstName, string lastName, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public virtual void Work() 
        {
            Console.WriteLine("Employee at Work! Do not distrupt!");
        }

        public void Pause() 
        {
            Console.WriteLine("I am having a break.");
        }


    }
}
