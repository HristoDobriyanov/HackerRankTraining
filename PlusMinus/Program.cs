using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void plusMinus(int[] arr)
        {
            Decimal pos = 0;
            Decimal neg = 0;
            Decimal[] ret = new decimal[3];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    pos++;
                }
                else if (arr[i] < 0)
                {
                    neg++;
                }

            }
            ret[0] = pos / arr.Length;
            ret[1] = neg / arr.Length;
            ret[2] = (arr.Length - pos - neg) / arr.Length;

            foreach (var item in ret)
            {
                Console.WriteLine(item);
            }

        }


        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 0, -1, -1 };

            plusMinus(arr);

            Decimal some = 2;
            Decimal other = 5;

            Decimal res = some / other;

            Console.WriteLine(res);

        }
    }
}
