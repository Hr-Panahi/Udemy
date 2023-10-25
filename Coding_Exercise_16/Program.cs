using System;
using System.Collections.Generic;

namespace Coding_Exercise_16
{
    class Program
    {
        static Func<float, float, float> Plus = (a,b) => a + b;
        static Func<float, float, float> Minus = (a,b) => a - b;
        static Func<float, float, float> Divide = (a,b) => a / b;
        static Func<float, float, float> Multiply = (a,b) => a * b;

        static public Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>
        {
            { "+",Plus },
            { "-",Minus },
            { "/",Divide },
            { "*",Multiply },
        };

        public static Func<float, float, float> OperationGet(string s)
        {
            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            else
            {
                return null;
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}

/*

Subject:

Create a dictionary that will contain <string, Func<>> pairs.
The keys will be operation signs "+", "-", "/", "*" and values 
will be the lambda expressions that will perform the corresponding 
operation on two floats and return a result with type float.


One more time in detail:

1. Create and store using static keyword Lambda expressions with names Plus, Minus, Divide and Multiply.

You can store function as follow:
     static Func<int, int> Name = (a) => a;

2. Create a static dictionary called Operators that uses a string as a Key and lambda function as a value.
     Example: {"sign", Function}

3. Create a static method OperationGet that will get as input a string, test if this string is a Key in the 
dictionary and if positive return function otherwise returns null.

*/