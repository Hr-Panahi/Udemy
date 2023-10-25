using System;

namespace Coding_Exercise_15
{
    class Program
    {
        //defining a deligate which takes 2 arguments
        public delegate float OperationDelegate(float arg1, float arg2);

        static void Main(string[] args)
        {
            Console.WriteLine(ApplyOperation(10, 2, Add));
            Console.WriteLine(ApplyOperation(10, 2, Subtract));
            Console.WriteLine(ApplyOperation(10, 2, Multiply));
            Console.WriteLine(ApplyOperation(11.5f, 2, Divide));
        }

        //------ 3. Creating a method which takes two args and one Delegate ----///
        public static float ApplyOperation(float arg1, float arg2, OperationDelegate operation)
        {
            return operation(arg1, arg2);
        }

        //------ 2.Creating Methods -----//
        public static float Add(float arg1, float arg2)
        {
            return arg1 + arg2;
        }
        public static float Subtract(float arg1, float arg2)
        {
            return arg1 - arg2;
        }
        public static float Multiply(float arg1, float arg2)
        {
            return arg1 * arg2;
        }
        public static float Divide(float arg1, float arg2)
        {
            return arg1 / arg2;
        }
    }
}

/*
Hands - on Delegates!

Subject:

1. Create a public delegate that will be called OperationDelegate and will 
get two arguments with float type and return float as well;

2. Create 4 static public methods called Add, Subtract, Multiply, and Divide. 
All of them should get 2 arguments and return a float that corresponds to the result of the performed operation;

3. Create a public static ApplyOperation method that gets 2 floats and one delegate 
and applies the operation to those values and returns the result as a float;
*/