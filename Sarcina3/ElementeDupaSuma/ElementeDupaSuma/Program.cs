using System;
using System.Collections.Generic;

namespace ElementeDupaSuma
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTests();
        }

        public static void FindElementsForSum(List<uint> listă, ulong sum, out int început, out int sfârșit)
        {
            început = 0;
            sfârșit = 0;

            int left = 0;
            ulong currentSum = 0;

            for (int right = 0; right < listă.Count; right++)
            {
                currentSum += listă[right];

                while (currentSum > sum && left <= right)
                {
                    currentSum -= listă[left];
                    left++;
                }

                if (currentSum == sum)
                {
                    început = left;
                    sfârșit = right;
                    return;
                }
            }

            început = 0;
            sfârșit = 0;
        }

        static void RunTests()
        {
            Test(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 11, 5, 7);
            Test(new List<uint> { 4, 5, 6, 7 }, 18, 1, 3);
            Test(new List<uint> { 0, 1, 2, 3, 4, 5, 6, 7 }, 88, 0, 0);
            Test(new List<uint> { 1, 1, 1, 1, 1 }, 3, 0, 2);
            Test(new List<uint> { 10, 20, 30, 40, 50 }, 90, 1, 3);
            Test(new List<uint> { 1_000_000, 2_000_000, 3_000_000 }, 5_000_000, 0, 1);
        }

        static void Test(List<uint> list, ulong sum, int expectedStart, int expectedEnd)
        {
            FindElementsForSum(list, sum, out int start, out int end);

            if (start == expectedStart && end == expectedEnd)
            {
                Console.WriteLine($"Test Passed: start={start}, end={end}");
            }
            else
            {
                Console.WriteLine($"Test Failed: got start={start}, end={end}, expected start={expectedStart}, end={expectedEnd}");
            }
        }
    }
}
