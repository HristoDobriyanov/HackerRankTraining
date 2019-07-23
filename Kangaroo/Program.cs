using System;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kangaroo(0,3,5,2));


        }

        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x1 == x2)
            {
                return "YES";
            }

            if ((x1 > x2 && v1 >= v2) || (x2 > x1 && v2 >= v1) || (x1 != x2 && v1==v2))
            {
                return "NO";
            }




            return "NO";
        }

    }
}
