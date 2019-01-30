using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMaxSum
{
    class Program
    {
        static void miniMaxSum(int[] arr)
        {
            Int64[] newArr = new Int64[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = (Int64)arr[i];
            }

            Console.Write(newArr.Sum() - newArr.Max());
            Console.Write(' ');
            Console.Write(newArr.Sum() - newArr.Min());
        }



        static void Main(string[] args)
        {
            int[] arr = new int[] { 396285104, 573261094, 759641832, 819230764, 364801279 };

            miniMaxSum(arr);            
        }
    }
}
