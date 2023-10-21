using System;
using System.Collections.Generic;
using System.IO;

namespace Parsing_Game_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reading the text file
            string[] readingLines = File.ReadAllLines
                (@"E:\CS_Internship\Udemy\Parsing_Game_1\input.txt");

            //Declarating a List of Strings to store the words in it
            List<string> myStringList = new List<string>();

            //Looking over all lines of the text file and splitting the lines which has "split"
            foreach (string line in readingLines)
            {
                if (line.Contains("split"))
                {
                    string[] splittedLine = line.Split(" split ");
                    string[] splittedWords = splittedLine[0].Split(" ");

                    //stroing element with index 4 in each line to myStringList
                    myStringList.Add(splittedWords[4]);

                    //Writing elements of myStringList to our output.txt
                    using (StreamWriter file = new StreamWriter
                        (@"E:\CS_Internship\Udemy\Parsing_Game_1\output.txt"))
                    {
                        for (int i = 0; i < myStringList.Count; i++)
                        {
                            if (!string.IsNullOrEmpty(myStringList[i]))
                            {

                                //putting space between each word except the first element
                                if (i > 0)
                                {
                                    file.Write(" ");
                                }
                                file.Write(myStringList[i]);
                            }
                        }
                    }
                }
            }

        }
    }
}
/* 

Assignment 2: Parsing Game (part1) / Read from and write into a file

The rules:
Create a class Program with the Main method with code that will read from the input.txt line by line;
If one of the lines contains "split" find it;
And after, split it(use the split method from the string class)
Take the return from the split and write the element with index 4 into the output.txt ;
You have to add a space between each element to make it readable;
*/