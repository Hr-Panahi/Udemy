using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray1 = { 2, 3, 6, 7, 15, 6, 0, 21, 9, 1, 2, 3, 4 };
            Console.WriteLine(SumOfTwo(sampleArray1, 17));

            int[] sampleArray2 = { 3, 14, 9, 7, 15, 11, 6, 0, 21, 9, 1, 5, 3, 4 };
            Console.WriteLine(SumOfTwo(sampleArray2, 4));
        }   
        public static int SumOfTwo(int[] nums, int SumToFind)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int result = 0;

            foreach (int value in nums)
            {
                if (dic.ContainsKey(SumToFind - value) && dic[SumToFind - value] > 0)
                {
                    dic[SumToFind - value] -= 1;
                    result++;
                    continue;
                }
                if (dic.ContainsKey(value))
                    dic[value] += 1;

                else
                    dic.Add(value, 1);
            }
            return result;
        }
    }
}
