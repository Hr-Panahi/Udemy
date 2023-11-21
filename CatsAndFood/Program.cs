using System;
using System.Collections.Generic;

namespace CatsAndFood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Show me your kitchen: ");
            string kitchen = Console.ReadLine();
            Console.WriteLine(NotHungryCats(kitchen));
        }
        public static int NotHungryCats(string kitchen)
        {
            string beforeFood = (kitchen.Substring(0, kitchen.IndexOf("F"))).Trim();
            string afterFood = (kitchen.Substring(kitchen.IndexOf("F") + 1)).Trim();

            int notHungryCats = 0;

            for (int i = 0; i < beforeFood.Length - 1; i += 2)
            {
                if (beforeFood[i].ToString() + beforeFood[i + 1].ToString() == "O~")
                    notHungryCats++;
            }
            for (int i = 0; i < afterFood.Length - 1; i += 2)
            {
                if (afterFood[i].ToString() + afterFood[i + 1].ToString() == "~O")
                    notHungryCats++;
            }
            return notHungryCats;
        }
    }
}
/*
Udemy Course: Section 20

"Interview questions" is a pressing topic.
That is why we decided to start with kittens 😸😸😸😸

So imagine you are in a kitchen that is full of cats.
Every typical hungry cat will follow you if you hold some food, right?


Our goal is to count not hungry cats in the kitchen.

You with food in the kitchen will be marked as F
Every cat will be represented as ~O or O~ depending on the direction.

Examples:
Input: "~O~O~O~O F"
Return: 0(all cats follow you)

Input: "O~~O~O~O F O~O~"
Return: 1(one is not following)

*/