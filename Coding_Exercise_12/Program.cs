using System;

namespace Coding_Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // new instance 
            Gun pist = new Gun();

            // test for methods
            pist.Label();
            pist.Shoot();

            // verifying interface' and parent class
            if (pist is IShootable && pist is Weapon)
                System.Console.WriteLine("Yes, it is my parents.");
        }
    }
}

//Coding Exercise 12, Inheritance and Interfaces:

//Today,  imagine that you are a game developer. And you need to:
//      Create An interface called IShootable. It will contain a method Shoot;
//      Create a class Weapon with a Name attribute and method Label that will display
//    the name of a weapon in the format "This is X!", where X is a name of a weapon;
//      Create a class Gun that inherits from Weapon, can shoot with a "Bang!" message, has the name "Gun", and is able to show the label.