using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTheTriplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> score = new List<int> { 0, 0 };

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    score[0]++;
                }
                else if (a[i] < b[i])
                {
                    score[1]++;
                }
                else
                {
                    continue;
                }
            }
            return score;
        }


        static void Main(string[] args)
        {

        }
    }
}
