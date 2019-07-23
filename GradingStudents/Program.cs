using System;
using System.Collections.Generic;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grades = new List<int>() { 73, 67, 38, 33 };

            var result = gradingStudents(grades);

            //for (int i = 30; i < 40; i++)
            //{
            //    Console.WriteLine($"{i} % 5 = {i % 5}");
            //}


            foreach (var res in result)
            {
                Console.WriteLine(res);
            }

        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> returnList = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38 || grades[i] % 5 == 0)
                {
                    returnList.Add(grades[i]);
                }
                else
                {
                    if (grades[i] % 5 >= 3)
                    {
                        returnList.Add(grades[i] + (5 - grades[i] % 5));
                    }
                    else
                    {
                        returnList.Add(grades[i]);
                    }
                }
            }

            return returnList;
        }

    }
}
