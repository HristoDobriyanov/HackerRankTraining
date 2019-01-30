using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCandles
{
    class Program
    {
        static int birthdayCakeCandles(int[] ar)
        {
            int candles = 0;
            int max = ar.Max();
            foreach (var item in ar)
            {
                if (item == max)
                {
                    candles++;
                }

            }
            return candles;
        }



        static void Main(string[] args)
        {
           
        }
    }
}
