using System;

namespace Inheritance_133
{
    class Trainee : Employee
    {
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }

        public Trainee() { }

        public Trainee(string firstName, string lastName, int salary, int workingHours, int schoolHours ) : base(firstName,lastName,salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I should learn casue I am a traineeeee!");
        }

        public override void Work()
        {
            Console.WriteLine($"Trainee Working Hours:{WorkingHours}");
        }
    }
}
