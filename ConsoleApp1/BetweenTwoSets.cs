using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BetweenTwoSets
    {
        public static int count(List<int> A, int max)
        {
            int modOfA = 0;
            for (int i = 0; i < A.Count(); i++)
            {
                if (max > A[i] && modOfA == 0)
                {
                    modOfA = max % A[i];
                }
                else if (max < A[i] && modOfA == 0)
                {
                    modOfA = A[i] % max;
                }
                else
                {
                    break;
                }
            }
            return modOfA;

        }
        public static void BetweenTwo(List<int> a, List<int> b)
        {
            int max = a.Max();
            int returnOfA = 0, CountA = 0;
            List<int> A = new List<int>();
            A = a.Concat(b).ToList();
            returnOfA = count(A, max);
            while (returnOfA == 0)
            {
                CountA++;
                max = max * 2;
                returnOfA = count(A, max);
            }
        }
    }
}
