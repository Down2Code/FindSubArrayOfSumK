using System;

namespace SubArrayWithGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 3, 6, 8, 10 };
            SubArraySum(Array, 24);
            Console.ReadLine();
        }
        private static void SubArraySum(int[] Array,int sum)
        {
            int i = 0;
            int startIndex = 0;
            int sumSoFar = 0;
            while(i<Array.Length)
            {
                sumSoFar += Array[i];
                if(sumSoFar<sum)
                {
                    i++;
                }
                else if(sumSoFar>sum)
                {
                    sumSoFar = 0;
                    startIndex++;
                    i = startIndex;
                }
                else
                {
                    Console.WriteLine($"The value of starting position {startIndex} and ending position{i}");
                    break;
                }
            }
        }
    }
}
