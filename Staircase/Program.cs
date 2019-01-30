using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string spaces = new string(' ', n - 1 - i);
                string sharps = new string('#', i + 1);
                Console.Write(spaces);
                Console.Write(sharps);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= input / 2; i++)
            //{
            //    string dots = new string('.', i);
            //    string stars = new string('*', input - i * 2);
            //    Console.WriteLine("{0}{1}{0}", dots, stars, dots);
            //}

            staircase(input);

        }
    }
}
