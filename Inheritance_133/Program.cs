using System;

namespace Inheritance_133
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainee trainee1 = new Trainee("Hamid", "Legend", 0, 30, 50);
            trainee1.Work();
            trainee1.Learn();

            Employee employee1 = new Employee();
            employee1.Work();
            employee1.Pause();

            Boss boss = new Boss("Mark","Manson",20000,"Volvo");
            Console.WriteLine("My name is {0} {1}, Your Boss, I am here with my fancy {2}.", 
                              boss.FirstName, boss.LastName, boss.CompanyCar);
            boss.Lead();
        }
    }
}
