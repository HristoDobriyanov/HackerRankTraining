using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace AppleAndOrange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] apples = new[] {-2, 2, 1};
            int[] oranges = new[] { 5, -6 };
            

            countApplesAndOranges(7,11,5, 15, apples, oranges);       
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleHits = 0;
            int OrangeHits = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                if (a + apples[i] >= s && a + apples[i] <= t)
                {
                    appleHits++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                if (b + oranges[i] >= s && b + oranges[i] <= t)
                {
                    OrangeHits++;
                }
            }

            Console.WriteLine(appleHits);
            Console.WriteLine(OrangeHits);

        }
    }
}
