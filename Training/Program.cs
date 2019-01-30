using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace Training
{
    class Program
    {
        static int diagonalDifference(int[][] arr)
        {
            int d1 = 0;
            int d2 = 0;

            for (int rows = 0; rows < arr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < arr[rows].Length; cols++)
                {
                    if (rows == cols)
                    {
                        d1 += arr[rows][cols];
                    }
                     if (rows + cols == arr.GetLength(0) - 1)
                    {
                        d2 += arr[rows][cols];
                    }
                }
            }
            return Math.Abs(d1 - d2);
        }


        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = diagonalDifference(arr);
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}


