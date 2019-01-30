using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            if (s.Substring(s.Length - 2) == "AM")
            {
                return s.Substring(0, 9);
            }
            else
            {
                int firstNum = Int32.Parse(s.Substring(0, 2)) + 12;
                string end = s.Substring(2, 6);

                return firstNum + end;
            }
        }



        static void Main(string[] args)
        {
            string indata = "07:05:45PM";

            //Console.WriteLine(indata.Substring(indata.Length - 2));
            //Console.WriteLine(indata.Substring(0, 2));

            Console.WriteLine(timeConversion(indata)) ;


        }
    }
}
