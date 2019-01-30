using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArraySum
{
    class Program
    {
        static int simpleArraySum(int[] ar)
        {
            int result = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                result += ar[i];
            }

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
