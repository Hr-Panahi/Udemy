using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Parsing_Game_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string readingAllText = File.ReadAllText
                (@"E:\CS_Internship\Udemy\Parsing_Game_2\input2.txt");

            string pattern = @"\d{2,3}";

            Regex regex = new Regex(pattern);

            MatchCollection matchCollection = regex.Matches(readingAllText);

            foreach(Match m in matchCollection)
            {
                GroupCollection group = m.Groups;
                var myValue = int.Parse(group[0].Value);
                Console.Write((char)myValue);
            }

        }
    }
}

/*
Subject:

Read and store the whole text from the source file;

Using regular expressions find all sequences of numbers that has length 2 or 3;

Pars every value into an integer;

Use casting to convert every integer into a char. It will look like that:
(char)YourValue;

and just print the result of each cast on the new line;
*/
