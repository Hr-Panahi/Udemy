using System;

namespace Inheritance_133
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss() { }
        
        public Boss(string firstName, string lastName, int salary, string companyCar):base(firstName,lastName,salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Cause I Born To Lead!");
        }
    }
}
