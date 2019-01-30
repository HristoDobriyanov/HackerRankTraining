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
                if (s.Substring(0, 2) == "12")
                {
                    return "00" + s.Substring(2, 6);
                }
                return s.Substring(0, 8);
            }
            else
            {
                if (s.Substring(0, 2) == "12")
                {
                    return s.Substring(0, 8);
                }
                else
                {
                    int firstNum = Int32.Parse(s.Substring(0, 2)) + 12;
                    string end = s.Substring(2, 6);
                    return firstNum + end;
                }


            }
        }



        static void Main(string[] args)
        {
            string indata = "12:45:54PM";

            //Console.WriteLine(indata.Substring(indata.Length - 2));
            //Console.WriteLine(indata.Substring(0, 2));

            Console.WriteLine(timeConversion(indata));


        }
    }
}
