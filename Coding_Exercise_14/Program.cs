using System;

namespace Coding_Exercise_14
{
    class Program
    {

        static void Main(string[] args)
        {
            Run("0");
        }
        public static double ConvertToRadians(double angle)
        {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line)
        {
            int angle;
            if (Int32.TryParse(line, out angle) == false || angle > 180 || angle < 0)
            {
                Console.WriteLine("Check the input!");
                return;
            }

            Console.WriteLine("Cos= {0}", Math.Cos(ConvertToRadians(angle)));
            Console.WriteLine("Sin= {0}", Math.Sin(ConvertToRadians(angle)));
            Console.WriteLine("Tg= {0}", Math.Tan(ConvertToRadians(angle)));
        }
    }
}

/*
Subject:

Complete the Run Method with code that will:

Pars line into int if it is possible. Otherwise, or if the value is not in the 
range between 0 and 180, display "Check the input!" on the new line and return;

if the parsing was successful, calculate and print:
     Cosine of this angle in the format "Cos = X", where X is the value;
     Sine of the angle in the format "Sin = X", where X is the value;
     Tangent of the angle in the format "Tg = X", where X is the value;

Hint: All of those methods expect us to provide radians as input.
In order to convert the angle to radians, use the method ConvertToRadians.
*/