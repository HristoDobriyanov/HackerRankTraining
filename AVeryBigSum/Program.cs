using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
